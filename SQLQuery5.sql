use[master]
create database MyNoteBook


use[MyNoteBook]


create table Person(
Id int IDENTITY(1,1) not null,
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
Id int IDENTITY(1,1) not null,
PersonId int not null,
PhoneName nvarchar(100), 
Number char(15) not null,
primary key(Id),
Foreign key(PersonId) references Person
         on update cascade
		 on delete cascade
)


drop table Person
drop table PhoneNumber


SET IDENTITY_INSERT Person ON
insert into Person (Id, NationalCode, FirstName, FamilyName, FatherName, Adress, Birthday, Gender)
Values ('1', '1080273697',		'ALI',		'ZARE',			'bahram',		'YAZD',		getdate()-(365*22),1),
       ('2', '1084527369',		'Mahdi',	'sobhani',		'reza',			'esfahan',	getdate()-(365*25),1),
	   ('3', '1080277857',		'Mahdi',	'sobhani',		'farhad',		'tehran',	getdate()-(365*18),1),
	   ('4', '1080253669',		'ALI',		'sobhani',		'farhad',		'esfahan',	getdate()-(365*20),1),
	   ('5', '1082587281',		'ala',		'mohammadi',	'parham',		'esfahan',	getdate()-(365*40),0)
SET IDENTITY_INSERT Person OFF


insert into PhoneNumber (PersonId, PhoneName, Number)
Values ('1',		'Mobile',	'09132427887'),
       ('2',		'Mobile',	'099352044752'),
	   ('2',		'Work',		'0312524512'),
	   ('3',		'Home',		'0315654269')
	   
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







