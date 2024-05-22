use[master]
create database MyNoteBook2


use[MyNoteBook2]



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


insert into Person (NationalCode,FirstName,FamilyName,FatherName,Adress,Birthday,Gender)
Values ('1080273697',		'ALI',		'ZARE',			'bahram',		'YAZD',		getdate()-(365*22),1),
       ('1084527369',		'Mahdi',	'sobhani',		'reza',			'esfahan',	getdate()-(365*25),1),
	   ('1080277857',		'Mahdi',	'sobhani',		'farhad',		'tehran',	getdate()-(365*18),1),
	   ('1080253669',		'ALI',		'sobhani',		'farhad',		'esfahan',	getdate()-(365*20),1),
	   ('1082587281',		'ala',		'mohammadi',	'parham',		'esfahan',	getdate()-(365*40),0)



delete from Person 
delete from PhoneNumber 




create procedure InsertPhoneNumber
@PersonName nvarchar(250),@PhoneNAME NVARCHAR(250),@PhoneNumber CHAR(15)
AS
	if (select count(id) from Person where Person.FirstName+' '+Person.FamilyName = @PersonName) = 1
	begin
		insert into PhoneNumber (PersonId,PhoneName,Number)
		values ((select id from Person where Person.FirstName+' '+Person.FamilyName = @PersonName),
				@PhoneNAME,
				@PhoneNumber);
		print 'Successful'
	end
	else
		print 'Not Successful'
GO


drop procedure InsertPhoneNumber


--Mahdi sobhani
--ALI ZARE
EXEC InsertPhoneNumber 'ALI ZARE','Mobile','09132427887';
EXEC InsertPhoneNumber 'Mahdi sobhani','Mobile','099352044752';



select * from Person



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



SELECT Person.NationalCode, FirstName + ' ' +FamilyName as Name, Number, PhoneName
from Person inner join PhoneNumber 
on Person.Id = PhoneNumber.PersonId







