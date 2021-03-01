namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TranBreakAdd : DbMigration
    {
        public override void Up()
        {
         
            Sql(@"
                    CREATE PROCEDURE [dbo].[ZadPodsumowania](@UserId as int,@Start as varchar(8),@Stop as varchar(8))
                    as
                    BEGIN
	                    SELECT 
	                     u.Name+' '+u.Surname as [User]
	                    ,el.Name
	                    ,ztl.Quantity as 'Ilosc'
	                    ,ISNULL(CONVERT(VARCHAR(8), DATEADD(S,SUM(DATEDIFF(S,zdt.Start,zdt.Stop)),0),108),'00:00:00') as 'Czaspracy'
	                     FROM 
		                     zadTaskProduction as zdt
		                    join zadTaskList as ztl on zdt.IdTask=ztl.IdTask
		                    join zadElement as el on ztl.IdElement=el.IdElement
		                    join genUsers as u on zdt.IdUser=u.IdUser
	                    WHERE 
		                    zdt.IdUser=@UserId and zdt.Stop is not null AND zdt.Start>@Start AND zdt.Stop<@Stop
	                    GROUP BY 
		                    u.Name,u.Surname,el.Name,ztl.Quantity
                    END
                GO
"
);
        }
        
        public override void Down()
        {
        }
    }
}
