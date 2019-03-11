namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDataSeed : DbMigration
    {
        public override void Up()
        {
            //grupy uprawnie�
            Sql("insert into genRoles (IdRole,Name,Active) values (1,'Administrator',1)");
            Sql("insert into genRoles (IdRole,Name,Active) values (2,'Szef',1)");
            Sql("insert into genRoles (IdRole,Name,Active) values (3,'Kierownik',1)");
            Sql("insert into genRoles(IdRole,Name,Active) values (4,'Kadrowa',1)");
            Sql("insert into genRoles (IdRole,Name,Active) values (5,'Pracownik',1)");

            //Struktura
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Meblex',null)");
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Dzia� handlowy',1)");
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Dzia� kadr',1)");
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Dzia� IT',1)");
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Dzia� produkcji',1)");
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Dzia� ksi�gowy',1)");

            //Type nieprzypisany
            Sql("insert into zadTypes(TypeName, Active) values('Nieprzypisany', 1)");




            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Jan','Kowalski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Antoni','Nowak',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Marian','Wisniewski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Maciej','Bara�ski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Stefan','Hula',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Andrzej','Dudu�',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Przemek','Lipski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Zbigniew','Pod�y',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('�ukasz','Gro�ny',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Stefan','Okrutny',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Janusz','D�ugi',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Sylwester','Nowacki',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Jacek','Wi�nia',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Piotr','Klos',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Grzegorz','Gospodarz',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Rafa�','Supron',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Dawid','Kubacki',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Kamil','Stoch',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Adam','Ma�ysz',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Krzysztof','Magik',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Jaros�aw','Kuczy�ski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Lech','Kuczkowski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Donald','Tuszy�ski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Sebastian','Morwa',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Jerzy','Stachowski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('S�awomir','Wasiak',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Czes�aw','Niemen',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Hans','Klos',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Piotr','Krosny',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Mateusz','Nowacki',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Andrzej','Brudnik',1,1)");


            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (1,'19880101','Warszawa','Lewartowskiego','','Gdansk','01-456',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (2,'19870101','Radom','G�rczewska','','Gdansk','02-692',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (3,'19860101','Krak�w','Marsza�kowska','','Gdansk','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (4,'19850101','Czestochowa','Anielewicza','','Warszawa','00-258',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (5,'19840101','Zakopane','Lazurowa','','Warszawa','01-456',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (6,'19880101','Warszawa','Doroszewskiego','','Warszawa','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (7,'19870101','Radom','Marsza�kowska','','Warszawa','02-692',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (8,'19860101','Krak�w','Czekoladowa','','Warszawa','00-258',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (9,'19850101','Czestochowa','Doroszewskiego','','Warszawa','01-456',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (10,'19840101','Zakopane','Marsza�kowska','','Warszawa','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (11,'19880101','Warszawa','Anielewicza','','Warszawa','02-692',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (12,'19870101','Radom','Doroszewskiego','','Warszawa','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (13,'19860101','Krak�w','Czekoladowa','','Warszawa','01-456',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (14,'19850101','Czestochowa','Marsza�kowska','','Warszawa','01-100',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (15,'19840101','Zakopane','Czekoladowa','','Warszawa','02-692',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (16,'19850101','Czestochowa','Anielewicza','','Warszawa','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (17,'19840101','Zakopane','Czekoladowa','','Warszawa','01-456',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (18,'19880101','Warszawa','Marsza�kowska','','Warszawa','00-258',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (19,'19870101','Radom','Doroszewskiego','','Warszawa','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (20,'19860101','Krak�w','Czekoladowa','','Warszawa','02-692',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (21,'19850101','Czestochowa','Marsza�kowska','','Warszawa','01-456',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (22,'19840101','Zakopane','Al.KEN ','','Warszawa','00-258',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (23,'19850101','Czestochowa','Doroszewskiego','','Warszawa','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (24,'19840101','Zakopane','Lewartowskiego','','Warszawa','02-692',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (25,'19880101','Warszawa','G�rczewska','','Warszawa','01-456',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (26,'19870101','Radom','Lazurowa','','Warszawa','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (27,'19860101','Krak�w','Lewartowskiego','','Warszawa','02-692',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (28,'19850101','Czestochowa','G�rczewska','','Warszawa','01-123',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (29,'19840101','Zakopane','Lazurowa','','Warszawa','01-456',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (30,'19840101','Zakopane','G�rczewska','','Warszawa','02-692',0)");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode,IsWoman) values (31,'19870101','Radom','Al.KEN','','Warszawa','01-123',0)");


            //u�ytkownicy do dzia��w
            Sql("insert into genOrgUnitPriv values (1,2,1)");
            Sql("insert into genOrgUnitPriv values (2,2,1)");
            Sql("insert into genOrgUnitPriv values (3,2,1)");
            Sql("insert into genOrgUnitPriv values (4,2,1)");
            Sql("insert into genOrgUnitPriv values (5,2,1)");
            Sql("insert into genOrgUnitPriv values (6,2,1)");
            Sql("insert into genOrgUnitPriv values (7,3,1)");
            Sql("insert into genOrgUnitPriv values (8,3,1)");
            Sql("insert into genOrgUnitPriv values (9,4,1)");
            Sql("insert into genOrgUnitPriv values (10,4,1)");
            Sql("insert into genOrgUnitPriv values (11,5,1)");
            Sql("insert into genOrgUnitPriv values (12,5,1)");
            Sql("insert into genOrgUnitPriv values (13,5,1)");
            Sql("insert into genOrgUnitPriv values (14,5,1)");
            Sql("insert into genOrgUnitPriv values (15,5,1)");
            Sql("insert into genOrgUnitPriv values (16,5,1)");
            Sql("insert into genOrgUnitPriv values (17,5,1)");
            Sql("insert into genOrgUnitPriv values (18,5,1)");
            Sql("insert into genOrgUnitPriv values (19,5,1)");
            Sql("insert into genOrgUnitPriv values (20,5,1)");
            Sql("insert into genOrgUnitPriv values (21,5,1)");
            Sql("insert into genOrgUnitPriv values (22,5,1)");
            Sql("insert into genOrgUnitPriv values (23,5,1)");
            Sql("insert into genOrgUnitPriv values (24,5,1)");
            Sql("insert into genOrgUnitPriv values (25,5,1)");
            Sql("insert into genOrgUnitPriv values (26,5,1)");
            Sql("insert into genOrgUnitPriv values (27,5,1)");
            Sql("insert into genOrgUnitPriv values (28,5,1)");
            Sql("insert into genOrgUnitPriv values (29,5,1)");
            Sql("insert into genOrgUnitPriv values (30,6,1)");
            Sql("insert into genOrgUnitPriv values (31,6,1)");


            //loginy
            Sql("insert into genLogin  values (1,'admin','admin',0)");
            Sql("insert into genLogin  values (2,'b','b',0)");
            Sql("insert into genLogin  values (3,'c','c',0)");
            Sql("insert into genLogin  values (4,'d','d',0)");





            Sql("Insert into rcpTranType (IdTranType,Name) values (1,'Start');");
            Sql("Insert into rcpTranType (IdTranType,Name) values (2,'Stop');");
            Sql("Insert into rcpTranType (IdTranType,Name) values (3,'Przerwa');");
            Sql("Insert into rcpTranType (IdTranType,Name) values (4,'Koniec przerwy');");



            Sql(" insert into rcpDay  (Name, CStart, CStop, IEarly, ILate, OEarly,OLate, [Break], Active) values ('7-15','07:00','15:00',10,10,10,0,15,1)");
            Sql(" insert into rcpDay  (Name, CStart, CStop, IEarly, ILate, OEarly,OLate, [Break], Active) values ('8-16','08:00','16:00',10,10,0,15,15,1)");
            Sql(" insert into rcpDay  (Name, CStart, CStop, IEarly, ILate, OEarly,OLate, [Break], Active) values ('9-17','09:00','17:00',10,10,0,0,15,1)");
            Sql(" insert into rcpDay  (Name, CStart, CStop, IEarly, ILate, OEarly,OLate, [Break], Active) values ('7.30-15.30','07:30','15:30',15,15,10,10,15,1)");
            Sql(" insert into rcpDay  (Name, CStart, CStop, IEarly, ILate, OEarly,OLate, [Break], Active) values ('10-18','10:00','18:00',15,15,10,10,15,1)");
            Sql(" insert into rcpDay  (Name, CStart, CStop, IEarly, ILate, OEarly,OLate, [Break], Active) values ('6-14','06:00','14:00',0,15,10,15,15,1)");
            Sql(" insert into rcpDay  (Name, CStart, CStop, IEarly, ILate, OEarly,OLate, [Break], Active) values ('14-22','14:00','22:00',10,10,10,10,15,1)");
            Sql(" insert into rcpDay  (Name, CStart, CStop, IEarly, ILate, OEarly,OLate, [Break], Active) values ('22-06','22:00','06:00',10,10,10,10,15,1)");


            //Hamrmonogramy
            Sql(" insert into rcpHarmo values ('Stanard 8-16')");
            Sql(" insert into rcpHarmo values ('Stanard 9-17')");
            Sql(" insert into rcpHarmo values ('Mieszany')");
            Sql(" insert into rcpHarmo values ('Mieszany 1/2 etatu')");
            Sql(" insert into rcpHarmo values ('I zmiana')");
            Sql(" insert into rcpHarmo values ('II zmiana')");
            Sql(" insert into rcpHarmo values ('Nocka')");
            Sql(" insert into rcpHarmo values ('Weekend SB-ND')	");
            Sql(" insert into rcpHarmo values ('Weekend SB')");


            //DEfinicje Harmonogram�w
            //8 - 16
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (1,2,2)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (1,3,2)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (1,4,2)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (1,5,2)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (1,6,2)");
           //9-17													 
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (2,2,3)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (2,3,3)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (2,4,3)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (2,5,3)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (2,6,3)");
            //Mieszany												  
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (3,2,4)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (3,3,4)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (3,4,4)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (3,5,4)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (3,6,4)");
            //Mieszany 1/2 etatu									  
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (4,2,5)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (4,3,5)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (4,4,5)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (4,5,5)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (4,6,5)");
            //I zmiana												 
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (5,2,6)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (5,3,6)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (5,4,6)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (5,5,6)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (5,6,6)");
            //II zmiana
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (6,2,7)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (6,3,7)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (6,4,7)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (6,5,7)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (6,6,7)");
            //Nocka												  
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (7,2,8)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (7,3,8)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (7,4,8)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (7,5,8)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (7,6,8)");
            //Weekend SB-ND										  
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (8,7,3)");
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (8,1,3)");
            //Weekend SB											 
            Sql("insert into rcpHarmoDef (IdHarmo,WDay,IdDay) values (9,7,3)");

            //Produkty
            Sql("insert into zadProduct (Name, Active,Description) values('St� rozk�adany OPAL 1',1,'St� rozk�adany OPAL 1');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� rozk�adany TIZIANO EST42 D39',1,'St� rozk�adany TIZIANO EST42 D39');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� rozk�adany AVENSIS typ75',1,'St� rozk�adany AVENSIS typ75');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� rozk�adany LYON LYOT04',	1,'	St� rozk�adany LYON LYOT04');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� rozk�adany ASTER',1,'St� rozk�adany ASTER');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� LONG ISLAND',1,'St� LONG ISLAND');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� KALISTO',1,'St� KALISTO');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� WERONA W-20',1,'St� WERONA W-20');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� ARTISTICO',1,'St� ARTISTICO');");
            Sql("insert into zadProduct (Name, Active,Description) values('St� YOUR WAY',1,'St� YOUR WAY');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o HETTA 3002BD',1,'Krzes�o HETTA 3002BD');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o PARTY PDC-044',1,'Krzes�o PARTY PDC-044');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o VILLA DCCA001',1,'Krzes�o VILLA DCCA001');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o ALEX',1,'Krzes�o ALEX');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o ICE HIGLOPP',	1	,'Krzes�o ICE HIGLOPP');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o ELIPSA',1,	'Krzes�o ELIPSA');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o MADERA LUX',1,'Krzes�o MADERA LUX ');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o JAWA 2015',1,'Krzes�o JAWA 2015');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o MODENA LUX',1,'Krzes�o MODENA LUX');");
            Sql("insert into zadProduct (Name, Active,Description) values('Krzes�o BOSTON CAFE',1,'Krzes�o BOSTON CAFE');");
            Sql("insert into zadProduct (Name, Active,Description) values('��ko YOOP YPL09',1,'��ko YOOP YPL09');");
            Sql("insert into zadProduct (Name, Active,Description) values('��ko JULIETTA JLTL162',1,'��ko JULIETTA JLTL162');");



            //Typy
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie blatu BD412060',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie blatu BD311050',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie blatu BS514060',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie blatu BS516070',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie blatu BSK100',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie blatu BSK90',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi NS10',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi NS12',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi NSF6',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi NDF8',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi NAF7',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi NAF5',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie oparcia ODK6040',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie oparcia ODS6040',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie oparcia ODP6040',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie siedziska SDW6040',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie siedziska SDP5060',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie siedziska SDF50',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi krzes�a NKS50',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi krzes�a NKSF5',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie nogi krzes�a NKDF4',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie wzmocnienia WD50',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie wzmocnienia WS40',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie wzmocnienia WS60',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie zag��wka ZD12016012',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie zag��wka ZD13018012',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie stelarza SD200160',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie stelarza SD200180',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie ramy RLY',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie ramy RLJ',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie n�ki NY',1);");
            Sql("insert into zadTypes (TypeName,Active) values ('Tworzenie n�ki NJ',1);");



            //Elementy
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Blat d�bowy 4x120x60cm',2,1,'BD412060');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Blat d�bowy 3x110x50cm',3,1,'BD311050');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Blat sklejkowy 5x140x60cm',4,1,'BS514060');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Blat sklejkowy 5x160x70cm',5,1,'BS516070');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Blat szklany fi100cm',6,1,'BSK100');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Blat szklany fi90cm',7,1,'BSK90');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga sklejka 10x10',8,1,'NS10');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga sklejka 12x12',9,1,'NS12');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga sklejka fi 6cm',10,1,'NSF6');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga d�bowa fi 8cm',11,1,'NDF8');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga aluminiowa fi 7cm',12,1,'NAF7');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga aluminiowa fi 5cm',13,1,'NAF5');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Oparcie drewniane kratka 60x40',14,1,'ODK6040');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Oparcie drewniane szczebelkowe 60x40',15,1,'ODS6040');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Oparcie drewniane pe�ne 60x40',16,1,'ODP6040');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Siedzisko drewniane wkl�s�e 60x40',17,1,'SDW6040');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Siedzisko drewniane proste 50x60',18,1,'SDP5060');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Siedzisko d�bowe fi50',19,1,'SDF50');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga do krzes�a sklejka 50cm',20,1,'NKS50');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga do krzes�a sklejka fi5cm',21,1,'NKSF5');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Noga do krzes�a d�bowa fi4cm',22,1,'NKDF4');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Wzmocnienie d�bowe 50',23,1,'WD50');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Wzmocnieni sklejka 40',24,1,'WS40');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Wzmocnienie sklejka 60',25,1,'WS60');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Zag��wek d�bowy 120x160x12cm',26,1,'ZD12016012');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Zag��wek d�bowy 130x180x12cm',27,1,'ZD13018012');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Stelarz d�bowy 200x160cm',28,1,'SD200160');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Stelarz d�bowy 200x180cm',29,1,'SD200180');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Rama ��ka Yoop',30,1,'RLY');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('Rama ��ka Julietta',31,1,'RLJ');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('N�ki Yoop',32,1,'NY');");
            Sql("insert into zadElement (Name,IdType,Active,Symbol) values ('N�ki Julietta',33,1,'NJ');");


            //elementy produktu
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,2,1)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,10,1)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,3,2)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,8,2)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,4,3)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,7,3)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,3,4)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (3,9,4)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,4,5)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,11,5)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,2,6)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,12,6)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (2,2,7)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (8,10,7)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,5,8)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (6,12,8)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,6,10)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,9,10)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,3,9)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,9,9)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,13,11)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,16,11)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,19,11)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (3,23,11)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,14,12)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,17,12)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,20,12)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (3,24,12)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,15,13)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,17,13)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,20,13)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (3,23,13)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,13,14)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,18,14)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,21,14)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (3,22,14)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,14,15)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,16,15)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,20,15)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,15,16)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,18,16)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (3,21,16)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,13,17)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,17,17)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,21,17)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,14,18)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,21,18)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,17,18)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,13,19)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,18,19)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,21,19)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,24,19)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,13,20)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,18,20)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,19,20)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (5,22,20)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,25,21)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,27,21)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,29,21)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (4,31,21)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,26,22)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,28,22)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,30,22)");
            Sql("insert into zadProdElem (Quantity,IdElement,IdProduct) values (1,32,22)");

            //obowi�zki
            Sql("insert into zadDuties (Name) values ('Blaty sklejkowe') ");
            Sql("insert into zadDuties (Name) values ('Nogi sklejkowe'      ) ");
            Sql("insert into zadDuties (Name) values ('Elementy d�bowe'     ) ");
            Sql("insert into zadDuties (Name) values ('Elementy szklane'    ) ");
            Sql("insert into zadDuties (Name) values ('Elementy aluminiowe' ) ");
            Sql("insert into zadDuties (Name) values ('Oparcia do krzese�'  ) ");
            Sql("insert into zadDuties (Name) values ('Siedziska do krzese�') ");
            Sql("insert into zadDuties (Name) values ('Dodatki sklejkowe'   ) ");
            Sql("insert into zadDuties (Name) values ('Ramy ��ek'          ) ");

            //obowi�zki powi�zania z zadaniami
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',4, 1)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',5, 1)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',8 ,2)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',9, 2)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',10,2)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',20,2)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',21,2)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',2, 3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',3, 3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',22,3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',23,3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',26,3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',27,3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',28,3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',29,3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',11,3)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',6, 4)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',7, 4)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',33,5)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',32,5)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',12,5)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',13,5)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',14,6)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',15,6)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',16,6)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',17,7)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',18,7)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',19,7)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',24,8)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',25,8)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',30,9)");
            Sql("insert into zadDutyTypes( Name,IdType,IdDuty) values ('',31,9)");

            //harmonogramy
            Sql("insert into rcpUserHarmo (IdUser,IdHarmo,ValidFrom,ValidTo) values(	1,	1,	'2018-01-01 23:44:59.000','2018-12-31 23:44:59.000')");
            Sql("insert into rcpUserHarmo (IdUser,IdHarmo,ValidFrom,ValidTo) values(	2,	2,	'2018-01-01 00:14:59.000','2018-12-31 00:14:59.000')");
            Sql("insert into rcpUserHarmo (IdUser,IdHarmo,ValidFrom,ValidTo) values(	3,	3,	'2018-01-01 00:14:59.000','2018-12-31 00:14:59.000')");
            Sql("insert into rcpUserHarmo (IdUser,IdHarmo,ValidFrom,ValidTo) values(	4,	5,	'2018-01-01 00:14:59.000','2018-12-31 00:14:59.000')");
            Sql("insert into rcpUserHarmo (IdUser,IdHarmo,ValidFrom,ValidTo) values(	5,	2,	'2018-01-01 00:14:59.000','2018-12-31 00:14:59.000')");



        }

        public override void Down()
        {
        }
    }
}
