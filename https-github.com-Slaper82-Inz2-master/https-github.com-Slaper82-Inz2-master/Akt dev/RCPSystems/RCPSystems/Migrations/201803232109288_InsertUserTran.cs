namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertUserTran : DbMigration
    {
        public override void Up()
        {
            Sql(@"declare @wzor as varchar(23),@wzor2 as varchar(23), @data as varchar(23),@data2 as varchar(23),@trans as int,@dzien as int,
                @prac as int
                set @dzien=0
                set @wzor='2018-03-01 09:00:00.000'
                set @wzor2='2018-03-01 17:00:00.000'
                set @prac=1
      
		                begin
			                while @dzien<31
				                Begin
					                set @data=dateadd(day, @dzien, convert(datetime2, @wzor))
					                set @data2=dateadd(day, @dzien, convert(datetime2, @wzor2))
							                if (select datepart(dw,@data))<>7 and (select datepart(dw,@data))<>1 
							                begin
								                insert into rcpTransactionAll values(@data,@prac,1)
								                insert into rcpTransactionAll values(@data2,@prac,2)
							                end
						                 set @dzien=@dzien+1
				                End		     
						End
");

            Sql(@"
    --2
	--Start
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-01 09:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-02 08:48:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-05 09:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-06 08:56:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-07 09:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-08 09:03:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-09 09:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-12 08:47:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-13 09:28:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-14 09:09:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-15 08:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-16 08:59:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-20 09:01:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-21 09:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-22 09:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-23 08:51:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-24 08:49:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-27 09:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-28 08:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-29 10:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,1,'2018-03-30 08:59:00');
	--Stop
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-01 17:07:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-02 16:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-05 17:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-06 16:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-07 17:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-08 17:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-09 17:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-12 16:54:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-13 16:47:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-14 17:07:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-15 17:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-16 16:42:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-20 15:36:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-21 17:01:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-22 16:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-23 17:21:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-24 16:49:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-27 17:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-28 16:45:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-29 17:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (2,2,'2018-03-30 17:09:00');
	


	--3
	--Start
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-01 09:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-02 08:48:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-05 09:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-06 08:56:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-07 09:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-08 09:03:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-09 09:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-12 08:47:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-13 09:28:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-14 09:09:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-15 08:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-16 08:59:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-20 09:01:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-21 09:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-22 09:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-23 08:51:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-24 08:49:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-27 09:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-28 08:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-29 10:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,1,'2018-03-30 08:59:00');
	--Stop
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-01 17:07:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-02 16:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-05 17:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-06 16:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-07 17:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-08 17:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-09 17:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-12 16:54:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-13 16:47:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-14 17:07:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-15 17:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-16 16:42:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-20 15:36:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-21 17:01:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-22 16:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-23 17:21:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-24 16:49:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-27 17:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-28 16:45:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-29 17:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (3,2,'2018-03-30 17:09:00');

	--4
	--Start
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-01 09:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-02 08:48:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-05 09:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-06 08:56:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-07 09:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-08 09:03:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-09 09:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-12 08:47:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-13 09:28:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-14 09:09:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-15 08:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-16 08:59:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-20 09:01:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-21 09:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-22 09:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-23 08:51:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-24 08:49:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-27 09:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-28 08:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-29 10:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,1,'2018-03-30 08:59:00');
	--Stop
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-01 17:07:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-02 16:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-05 17:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-06 16:55:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-07 17:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-08 17:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-09 17:00:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-12 16:54:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-13 16:47:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-14 17:07:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-15 17:02:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-16 16:42:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-20 15:36:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-21 17:01:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-22 16:12:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-23 17:21:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-24 16:49:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-27 17:04:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-28 16:45:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-29 17:11:00');
	Insert into rcpTransactionAll (IdUser,IdTransType,DateAndTime) values (4,2,'2018-03-30 17:09:00');
    ");
        }
        
        public override void Down()
        {
        }
    }
}
