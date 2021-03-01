namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TriggerBreak : DbMigration
    {
        public override void Up()
        {
            Sql(@"IF NOT EXISTS (select * from sys.objects where type = 'TR' and name = 'PARY_TRANS_BREAK')  EXEC dbo.sp_executesql @statement = N'

             CREATE  TRIGGER[dbo].[PARY_TRANS_BREAK]
                ON[dbo].[rcpTransactionAll]
                AFTER  INSERT
                AS

                    BEGIN

                        IF(Select IdTransType from inserted) = 3 and(select count(*) from rcpPairsOnB where CONVERT(Date, Start) = CONVERT(Date, (Select DateAndTime from inserted)) and IdUser=(select IdUser from inserted) and Stop is null ) = 0

                                begin
                                    Insert into rcpPairsOnB values((Select IdUser from inserted),(Select DateAndTime from inserted),null)
				                end
                    END
                '



            IF NOT EXISTS (select * from sys.objects where type = 'TR' and name = 'PARY_TRANS_BREAK_END')  EXEC dbo.sp_executesql @statement = N'

               CREATE TRIGGER[dbo].[PARY_TRANS_BREAK_END]
                        ON[dbo].[rcpTransactionAll]
                        AFTER INSERT
                AS
                    BEGIN
		                 if(Select IdTransType from inserted)=4 and(select count(*) from rcpPairsOnB where CONVERT(Date, Start)= CONVERT(Date, (Select DateAndTime from inserted)) and IdUser=(select IdUser from inserted) and[Stop] is null)=1
			                begin
                                declare @id as int set @id=(select IdUser from inserted)
				                declare @dataWsad as Datetime set @dataWsad=(Select DateAndTime from inserted)
				                declare @dataWej as Datetime set @dataWej=(Select top 1 Start from rcpPairsOnB where CONVERT(Date, Start)=CONVERT(Date, @dataWsad) and IdUser=@id order by[Stop] desc)
				                if(@dataWsad>@dataWej)
					                Begin
                                        update rcpPairsOnB
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
            Sql(@"IF EXISTS (select * from sys.objects where type = 'TR' and name = 'PARY_TRANS_BREAK')
                Drop Trigger [PARY_TRANS_BREAK]
                IF EXISTS (select * from sys.objects where type = 'TR' and name = 'PARY_TRANS_BREAK_END')
                Drop Trigger [PARY_TRANS_BREAK_END]");
        }
    }
}
