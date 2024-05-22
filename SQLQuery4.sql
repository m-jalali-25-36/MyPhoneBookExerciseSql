use[master]
create database MyNoteBook


use[MyNoteBook]


create table Person(
Id uniqueidentifier default newid() not null,
NationalCode char(10) not null,
FirstName  nvarchar(100) not null,
FamilyName nvarchar(100) not null,
FatherName nvarchar(100),
Adress     nvarchAR(200),
Birthday   datetime,
Gender     bit,
primary key(Id),
UNIQUE (NationalCode)
)



create table PhoneNumber(
Id uniqueidentifier default newid() not null,
PersonId uniqueidentifier not null,
PhoneName nvarchar(100), 
Number char(15) not null,
primary key(Id),
Foreign key(PersonId) references Person
         on update cascade
		 on delete cascade
)


drop table Person
drop table PhoneNumber


insert into Person (Id, NationalCode, FirstName, FamilyName, FatherName, Adress, Birthday, Gender)
Values ('3985B7C4-A714-4D91-A6D8-3A66B9A36559', '1080273697',		'ALI',		'ZARE',			'bahram',		'YAZD',		getdate()-(365*22),1),
       ('49593D98-ED8B-492A-970C-60F3F0C32297', '1084527369',		'Mahdi',	'sobhani',		'reza',			'esfahan',	getdate()-(365*25),1),
	   ('F1242675-F5C8-4B76-9D18-6913A167F8E4', '1080277857',		'Mahdi',	'sobhani',		'farhad',		'tehran',	getdate()-(365*18),1),
	   ('95B3121B-D2F3-44B2-9C78-C67C62E2A21F', '1080253669',		'ALI',		'sobhani',		'farhad',		'esfahan',	getdate()-(365*20),1),
	   ('7F543BA1-84AC-47AB-8579-C83523EE1426', '1082587281',		'ala',		'mohammadi',	'parham',		'esfahan',	getdate()-(365*40),0)



insert into PhoneNumber (PersonId, PhoneName, Number)
Values ('3985B7C4-A714-4D91-A6D8-3A66B9A36559',		'Mobile',	'09132427887'),
       ('49593D98-ED8B-492A-970C-60F3F0C32297',		'Mobile',	'099352044752'),
	   ('49593D98-ED8B-492A-970C-60F3F0C32297',		'Work',		'0312524512'),
	   ('F1242675-F5C8-4B76-9D18-6913A167F8E4',		'Home',		'0315654269')
	   
delete from Person 
delete from PhoneNumber 


select * from Person

select * from PhoneNumber


select NationalCode,FirstName + ' ' +FamilyName as Name,FatherName  from Person


select  NationalCode,
		FirstName + ' ' +FamilyName as Name,
		FatherName,
		case
			when Gender=1 then 'man'
			when Gender=0 then 'woman'
		end as Gender,
		DATEDIFF (yy,Birthday,cast(getdate() AS DATE)) as Age,
		Adress
from Person


SELECT Person.NationalCode, FirstName + ' ' +FamilyName as Name, FatherName, Number, PhoneName
from Person inner join PhoneNumber 
on Person.Id = PhoneNumber.PersonId







