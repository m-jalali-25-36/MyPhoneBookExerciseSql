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
Birthday   date,
Gender     bit,
primary key(Id)
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



create table Email(
Id uniqueidentifier default newid() not null,
PersonId uniqueidentifier not null,
EmailName nvarchar(100), 
Email char(250) not null,
primary key(Id),
Foreign key(PersonId) references Person
         on update cascade
		 on delete cascade

)



create table BankNumber(
Id uniqueidentifier default newid() not null,
PersonId uniqueidentifier not null,
BankName nvarchar(250),
CardNumber char(16) not null,
primary key(Id),
Foreign key(PersonId) references Person
         on update cascade
		 on delete cascade
)



 create table Grop(
 Id int not null IDENTITY(1,1)
 )

drop table Person
drop table PhoneNumber
drop table Email
drop table BankNumber



insert into Person (NationalCode,FirstName,FamilyName,FatherName,Adress,Birthday,Gender)
Values ('1080273697',		'ALI',		'ZARE',			'bahram',		'YAZD',		getdate()-(365*22),1),
       ('1084527369',		'Mahdi',	'sobhani',		'reza',			'esfahan',	getdate()-(365*25),1),
	   ('1080277857',		'Mahdi',	'sobhani',		'farhad',		'tehran',	getdate()-(365*18),1),
	   ('1080253669',		'ALI',		'sobhani',		'farhad',		'esfahan',	getdate()-(365*20),1),
	   ('1082587281',		'ala',		'mohammadi',	'parham',		'esfahan',	getdate()-(365*40),0)



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
EXEC InsertPhoneNumber 'Mahdi sobhani','Mobile','099352044752',1;



select * from Person



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



SELECT Person.NationalCode, FirstName + ' ' +FamilyName as Name, Email, EmailName
from Person inner join Email 
on Person.Id = Email.PersonId



SELECT Person.NationalCode, FirstName + ' ' +FamilyName as Name, CardNumber, BankName
from Person inner join BankNumber 
on Person.Id = BankNumber.PersonId





