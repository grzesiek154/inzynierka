namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Triggers : DbMigration
    {
        public override void Up()
        {
            Sql(@"IF NOT EXISTS (select * from sys.objects where type = 'TR' and name = 'PARY_TRANS')  EXEC dbo.sp_executesql @statement = N'
                CREATE  TRIGGER[dbo].[PARY_TRANS]
                ON[dbo].[rcpTransactionAll]
                AFTER  INSERT
                AS

                    BEGIN

                        IF(Select IdTransType from inserted) = 1 and(select count(*) from rcpPairsIO where CONVERT(Date, Start) = CONVERT(Date, (Select DateAndTime from inserted)) and Stop is null) = 0

                                begin
                                    Insert into rcpPairsIO values((Select IdUser from inserted),(Select DateAndTime from inserted),null)
				                end
                    END
                '
                

                IF NOT EXISTS(select * from sys.objects where type = 'TR' and name = 'PARY_TRANS_Out')
                EXEC dbo.sp_executesql @statement = N'
                CREATE TRIGGER[dbo].[PARY_TRANS_Out]
                        ON[dbo].[rcpTransactionAll]
                        AFTER INSERT
                AS
                    BEGIN
		                 if(Select IdTransType from inserted)=2 and(select count(*) from rcpPairsIO where CONVERT(Date, Start)= CONVERT(Date, (Select DateAndTime from inserted)) and[Stop] is null)=1
			                begin
                                declare @id as int set @id=(select IdUser from inserted)
				                declare @dataWsad as Datetime set @dataWsad=(Select DateAndTime from inserted)
				                declare @dataWej as Datetime set @dataWej=(Select top 1 Start from rcpPairsIO where CONVERT(Date, Start)=CONVERT(Date, @dataWsad) order by[Stop] desc)
				                if(@dataWsad>@dataWej)
					                Begin
                                        update rcpPairsIO
                                        set[Stop] = @dataWsad

                                        where IdUser = @id and Start = @dataWej

                                    End
                            end

                    END
                '
            ");
        }
        
        public override void Down()
        {
            Sql(@"IF EXISTS (select * from sys.objects where type = 'TR' and name = 'PARY_TRANS')
                Drop Trigger [PARY_TRANS]
                IF EXISTS (select * from sys.objects where type = 'TR' and name = 'PARY_TRANS_Out')
                Drop Trigger [PARY_TRANS_Out]");
        }
    }
}
