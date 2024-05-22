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
Category int,
primary key(Id),
Foreign key(PersonId) references Person
         on update cascade
		 on delete cascade
)


create table Grope(
Id int not null IDENTITY(1,1),
GropeName nvarchar(100), 
primary key(Id)
)



create table PersonGrope(
PersonId uniqueidentifier not null,
GropeId int not null,
primary key(PersonId,GropeId),
Foreign key(PersonId) references Person
         on update cascade
		 on delete cascade,
Foreign key(GropeId) references Grope
         on update cascade
		 on delete cascade
)



create table PersonToPerson(
Id uniqueidentifier not null,
PersonId uniqueidentifier not null,
RelName nvarchar(100),
primary key(Id,PersonId),
Foreign key(Id) references Person
         on update cascade
		 on delete cascade,
Foreign key(PersonId) references Person
         on update NO ACTION
		 on delete NO ACTION
)

drop table Person
drop table PhoneNumber
drop table Grope
drop table PersonGrope
drop table PersonToPerson



insert into Person (NationalCode,FirstName,FamilyName,FatherName,Adress,Birthday,Gender)
Values ('1080273697',		'ALI',		'ZARE',			'bahram',		'YAZD',		getdate()-(365*22),1),
       ('1084527369',		'Mahdi',	'sobhani',		'reza',			'esfahan',	getdate()-(365*25),1),
	   ('1080277857',		'Mahdi',	'sobhani',		'farhad',		'tehran',	getdate()-(365*18),1),
	   ('1080253669',		'ALI',		'sobhani',		'farhad',		'esfahan',	getdate()-(365*20),1),
	   ('1082587281',		'ala',		'mohammadi',	'parham',		'esfahan',	getdate()-(365*40),0)

select * from Person

insert into Grope (GropeName)
values	('Other'),
		('Family'),
		('Friends'),
		('Partners'),
		('Official')

select * from Grope

delete from Person 
delete from PhoneNumber 
delete from Email 
delete from BankNumber 


create procedure InsertPhoneNumber
@PersonName nvarchar(250),@PhoneNAME NVARCHAR(250),@PhoneNumber CHAR(15),@Category int
AS
	if (select count(id) from Person where Person.FirstName+' '+Person.FamilyName = @PersonName) = 1
	begin
		insert into PhoneNumber (PersonId,PhoneName,Number,Category)
		values ((select id from Person where Person.FirstName+' '+Person.FamilyName = @PersonName),
				@PhoneNAME,
				@PhoneNumber,
				@Category);
		print 'Successful'
	end
	else
		print 'Not Successful'
GO


drop procedure InsertPhoneNumber


--Mahdi sobhani
--ALI ZARE
EXEC InsertPhoneNumber 'ALI ZARE','Mobile','09132427887',1;
EXEC InsertPhoneNumber 'ALI sobhani','Mobile','0939852571',1;
EXEC InsertPhoneNumber 'ala mohammadi','Mobile','099235724',1;
EXEC InsertPhoneNumber 'Mahdi sobhani','Mobile','099352044752',1;



create procedure PersonAddToGrope
@NationalCode char(10),@IdGrope int
AS
	if (select count(id) from Person where Person.NationalCode = @NationalCode) = 1
	begin
		insert into PersonGrope (PersonId,GropeId)
		values ((select id from Person where Person.NationalCode = @NationalCode),
				@IdGrope);
		print 'Successful'
	end
	else
		print 'Not Successful'
GO


drop procedure InsertPhoneNumber


EXEC PersonAddToGrope '1080273697',1;
EXEC PersonAddToGrope '1084527369',3;
EXEC PersonAddToGrope '1080277857',2;
EXEC PersonAddToGrope '1082587281',2;


select NationalCode,FirstName + ' ' +FamilyName,FatherName as Name  from Person



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



SELECT Person.NationalCode, FirstName + ' ' +FamilyName as Name, Number, PhoneName
from Person inner join PhoneNumber 
on Person.Id = PhoneNumber.PersonId






