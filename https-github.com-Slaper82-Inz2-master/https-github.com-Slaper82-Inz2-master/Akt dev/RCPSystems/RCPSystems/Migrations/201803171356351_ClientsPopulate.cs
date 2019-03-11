namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientsPopulate : DbMigration
    {
        public override void Up()
        {
            Sql("insert into zadClient values ('Salon Meblowy Stefan',1);");
            Sql("insert into zadClient values ('Jurek Kowalski',1);");
            Sql("insert into zadClient values ('Agata Meble',1);");
            Sql("insert into zadClient values ('IKEA',1);");
            Sql("insert into zadClient values ('Nowy Salon Mody',1);");


            Sql("insert into zadOrder (CreateDate,IdUser,Description,Done,Active,IdClient) values ('2018-03-24 12:47:55.673',1,'Krzes³a',0,1,4)");
            Sql("insert into zadOrder (CreateDate,IdUser,Description,Done,Active,IdClient) values ('2018-03-24 13:48:25.763',1,'Sto³y',0,1,3)");

            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	13,	3	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	16,	3	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	19,	12	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	23,	9	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	14,	2	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	17,	2	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	20,	8	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	24,	6	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	13,	3	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	18,	3	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	21,	12	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	1,	22,	9	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	2,	2 ,	2	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	2,	10,	8	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	2,	4 ,	3	,1,	0 )");
            Sql("insert into zadTaskList(IdOrder,IdElement,Quantity,Active,Done) values(	2,	7 ,	12	,1,	0 )");


            //obowi¹zki dla usera1
            Sql("insert into zadUserDuties(IdUser,IdDuty) values (1,	1)");
            Sql("insert into zadUserDuties(IdUser,IdDuty) values (1,	2)");
            Sql("insert into zadUserDuties(IdUser,IdDuty) values (1,	3)");
            Sql("insert into zadUserDuties(IdUser,IdDuty) values (1,	4)");
        }
        
        public override void Down()
        {
        }
    }
}
