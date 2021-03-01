namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReportProcedure : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    CREATE PROCEDURE [dbo].[rcpRaport](@Id as int,@Start as nvarchar(8),@Stop as nvarchar(8))
                      AS
					BEGIN
                 --   Declare @ID as int =2,@Start as nvarchar(8) = '20180501',@Stop as nvarchar(8) = '20180531'
                     ;WITH KALHARMO AS(
                    SELECT uh.IDUSER
	                    ,C.DATEKEY
	                    ,C.DATE
	                    ,C.DAY
	                    ,ISNULL(rd.CSTART,'00:00:00') AS START
	                    ,ISNULL(rd.CSTOP,'00:00:00') AS STOP
	                    ,ISNULL(CONVERT(VARCHAR(8), DATEADD(S,SUM(DATEDIFF(S,rd.CSTART,rd.CSTOP)),0),108),'00:00:00') AS NORMA
                    FROM rcpDay AS rd
	                    join rcpHarmoDef as rhd on rd.IdDay=rhd.IdDay
	                    join rcpUserHarmo as uh on uh.IdHarmo=rhd.IdHarmo
	                    LEFT JOIN Calendar AS C ON rhd.WDAY=C.WEEKDAY
	                    WHERE IDUSER=@ID AND C.DATEKEY>=@START AND C.DATEKEY<=@STOP --PARAMETRY
	                    --TU PARAMETRY
	                    GROUP BY DATE,uh.IDUSER
	                    ,DATEKEY
	                    ,DATE
	                    ,DAY
	                    ,CSTART
	                    ,CSTOP
                    )
					--Select * from KALHARMO
                    , 
                    --SUMOWANIE CZASU NA PODSTAWIE DATY TABLICY PAR
                    PARYTMP AS(
                    SELECT distinct rp.Lp,rp.IdUser,rp.Start,rp.Stop
	                    ,DATEDIFF(S,rp.Start,rp.Stop) AS CZAS
	                    ,CONVERT(DATE,rp.Start) AS DATA
						,ISNULL(DATEDIFF(Mi,b.Start,b.Stop),0) AS PRZERWA					
                    FROM rcpPairsIO as rp
					Left Join rcpPairsOnB as b on Convert(Date,rp.Start)=Convert(Date,b.Start)
					Join KALHARMO as k on rp.IdUser=k.IdUser
					where rp.IdUser=k.IdUser and rp.Start>@Start and rp.Stop<@Stop
				--	group by rp.Lp,rp.IdUser,rp.Start,rp.Stop

                     )
					--Select * from PARYTMP
					 ,
                     --SUMOWANIE CZASU NA PODSTAWIE DNI
                    PARY AS(
                    SELECT pt.DATA
	                    ,CONVERT(VARCHAR(8), DATEADD(S,SUM(pt.CZAS),0),108) AS ODCZYTANE
						,pt.PRZERWA
						
                    FROM PARYTMP pt
                    WHERE pt.IDUSER=@ID
	                    GROUP BY pt.DATA,pt.PRZERWA
                     )
					--select * from PARY
					 ,
                     --PO£¥CZONE DANE HARMONOGRAM - ODCZYTY
                    NORMODCZYT AS(
                    SELECT KH.*,ISNULL(P.ODCZYTANE,'00:00:00') AS ODCZYTANE,P.PRZERWA
	                    FROM 
							KALHARMO AS KH
	                    LEFT JOIN PARY AS P ON KH.DATE=P.DATA
                    )
					--Select * from NORMODCZYT
                    --WARUNKI ¯EBY BY£O WIADOMO CZY MA NADGODZINY CZY BRAKI - JEST RÓ¯NICA PRZY ODEJMOWANIU
                    ,BRAKI AS
					(
                    SELECT I.IDUSER,I.DATEKEY,I.DATE,I.NORMA,ISNULL(I.PRZERWA,0) AS PRZERWA,I.ODCZYTANE,I.DAY,I.START,I.STOP,
	                    ISNULL(
							CASE WHEN I.NORMA>I.ODCZYTANE THEN  
								CONVERT(VARCHAR(8), DATEADD(S,SUM(DATEDIFF(S,CONVERT(TIME,ODCZYTANE),CONVERT(TIME,NORMA))),0),108) 

							END
							,'00:00:00') AS 'BRAKI'
	                    FROM 
							NORMODCZYT AS I
	                    GROUP BY 
							IDUSER,I.DATEKEY,I.DATE,I.DAY,I.START,I.STOP,I.NORMA,I.ODCZYTANE,I.PRZERWA
	                )
	            SELECT B.IDUSER,B.DATEKEY,B.DATE,B.NORMA,B.ODCZYTANE,B.PRZERWA,B.BRAKI,
	                    ISNULL(
							CASE WHEN B.NORMA<B.ODCZYTANE THEN  CONVERT(VARCHAR(8), DATEADD(S,SUM(DATEDIFF(S,CONVERT(TIME,NORMA),CONVERT(TIME,ODCZYTANE))),0),108) 
							END
						,'00:00:00') AS 'NADGODZINY'
						,STUFF((SELECT '; ' + CONVERT(char(10), p.Start,108), CONVERT(char(10), p.Stop ,108) 
							FROM 
								PARYTMP p
							WHERE 
								p.DATA=B.Date FOR XML PATH('')),1,1,'') as TRansakcje
	                    FROM 
							BRAKI AS B
	                    GROUP BY 
							B.IDUSER,B.DATEKEY,B.DATE,B.DAY,B.START,B.STOP,B.NORMA,B.ODCZYTANE,B.BRAKI,B.PRZERWA
         END

		 GO
         ");
        }
        
        public override void Down()
        {
        }
    }
}
