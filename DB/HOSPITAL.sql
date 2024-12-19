
CREATE DATABASE HOSPITAL;

GO

USE HOSPITAL;

GO

CREATE TABLE dbo.[ADDRESS](
idAddress int primary key identity(1, 1) not null,
street varchar(50) not null,
suburb varchar(50) not null,
city varchar(50) not null,
[state] varchar(50) not null
)

GO

CREATE TABLE PATIENT(
idPatient int identity(1, 1) primary key not null,
namePatient varchar(60) not null,
middleName varchar(50) not null,
lastName varchar(50) not null,
birthDate datetime not null,
telephone varchar(15) not null,
idAddress int references dbo.[ADDRESS](idAddress) not null
)

GO

CREATE TABLE RECIPE(
idRecipe int identity(1, 1) primary key not null,
namePatient varchar(250) not null,
medicalCondition varchar(150) not null,
treatment varchar(200) not null,
test varchar(200) not null,
testResult varchar(250) not null,
medicament varchar(200) not null,
doctor varchar(250) not null,
registerDate datetime not null,
idPatience int references Patient(idPatient) not null
)

GO

CREATE TABLE DOCTOR(
idDoctor int identity(1, 1) primary key not null,
nameDoctor varchar(60) not null,
middleName varchar(50) not null,
lastName varchar(50) not null,
birthDate datetime not null,
telephone varchar(15) not null,
idAddress int references dbo.[ADDRESS](idAddress) not null
)

GO

CREATE TABLE MEDICAMENT(
idMedicament int primary key identity(1, 1) not null,
nameMedicament varchar(50) not null,
dose varchar(50) not null,
useInstruction varchar(250) not null
)

GO

CREATE TABLE LABORATORY_RESULT(
idLaboratoryResult int primary key identity(1, 1) not null,
test varchar(150) not null,
resultValue varchar(150) not null,
dateDone datetime default getdate()
)

GO

CREATE TABLE TREATMENT(
idTreatment int primary key identity(1, 1) not null,
recommendTreatment varchar(250) not null,
startedDate datetime not null,
idMedicament int references Medicament(idMedicament)
)

GO

CREATE TABLE DIAGNOSTIC(
idDiagnostic int primary key identity(1, 1) not null,
medicalCondition varchar(250) not null,
registerDate datetime default getdate(),
idTreatment int references TREATMENT(idTreatment) not null,
idDoctor int references DOCTOR(idDoctor) not null,
idPatient int references PATIENT(idPatient) not null,
idLaboratoryResult int references LABORATORY_RESULT(idLaboratoryResult) not null
)

GO

-- STORE PROCEDURES
-- ADDRESS
create proc SP_Create_Address(
@street varchar(50),
@suburb varchar(50),
@city varchar(50),
@state varchar(50)
)as
begin
	
	insert into [ADDRESS] values(@street, @suburb, @city, @state);

end

GO

create proc SP_Update_Address(
@idAddress int,
@street varchar(50),
@suburb varchar(50),
@city varchar(50),
@state varchar(50)
)as
begin
	
	if exists(select * from [ADDRESS] where idAddress = @idAddress)
	begin

		update [ADDRESS] set
		street = @street, 
		suburb = @suburb, 
		city = @city, 
		[state] = @state
		where idAddress = @idAddress

	end

end

GO

create proc SP_Delete_Address(
@idAddress int
)as
begin

	if exists(select * from [ADDRESS] where idAddress = @idAddress)
	begin

		delete top(1) from [ADDRESS] where idAddress = @idAddress;
	end

end

GO

create proc SP_List_Address as
begin
	
	select * from [ADDRESS]

end

GO

create proc SP_List_Address_Complete as
begin
	
	select idAddress, concat(street, ' ', suburb, ' ', city, ' ', [state]) as 'address' from [ADDRESS]

end

GO

GO

USE HOSPITAL;

CREATE PROC SP_Get_Address_By_Id(
@idAddress int
)AS
BEGIN

	SELECT * FROM dbo.[ADDRESS] WHERE idAddress = @idAddress;

END

SELECT * FROM [ADDRESS]

GO

select * from DOCTOR
-- PATIENT
create proc SP_Create_Patient(
@namePatient varchar(60),
@middleName varchar(50),
@lastName varchar(50),
@birthDate datetime,
@telephone varchar(15),
@idAddress int
)as
begin
	
	insert into PATIENT values(@namePatient, @middleName, @lastName, @birthDate, @telephone, @idAddress);

end

GO

create proc SP_Update_Patient(
@idPatient int,
@namePatient varchar(60),
@middleName varchar(50),
@lastName varchar(50),
@birthDate datetime,
@telephone varchar(15),
@idAddress int,
@response int output
)as
begin
	
	set @response = 0

	if not exists(select * from PATIENT where namePatient = @namePatient 
	and middleName = @middleName and lastName = @lastName and birthDate = @birthDate 
	and telephone = @telephone and idAddress = @idAddress and idPatient != @idPatient)
	begin
		update PATIENT set 
		namePatient = @namePatient, 
		middleName = @middleName, 
		lastName = @lastName, 
		birthDate = @birthDate, 
		telephone = @telephone, 
		idAddress = @idAddress
		where idPatient = @idPatient;

		set @response = 1
	end

end

GO

create proc SP_Delete_Patient(
@idPatient int,
@response int output
)as
begin
	
	set @response = 0

	if exists(select * from PATIENT where idPatient = @idPatient)
	begin
		
		delete top(1) from PATIENT where idPatient = @idPatient;

		set @response = 1

	end

end

GO

create proc SP_List_Patients as
begin
	
	select p.idPatient, p.namePatient, p.middleName, p.lastName, p.birthDate, p.telephone,
	ad.idAddress, ad.street, ad.suburb, ad.city, ad.[state]
	from PATIENT p inner join [ADDRESS] ad on p.idAddress = ad.idAddress;

end

exec sp_rename 'SP_List_Patient', 'SP_List_Patients'

GO

create proc SP_Search_Patient_By_Id(
@idPatient int
)as
begin

	select p.idPatient, p.namePatient, p.middleName, p.lastName, p.birthDate, p.telephone,
	ad.idAddress, ad.street, ad.suburb, ad.city, ad.[state]
	from PATIENT p inner join [ADDRESS] ad on p.idAddress = ad.idAddress where p.idPatient = @idPatient;

end

GO
-- TREATMENT

create proc SP_Create_Treatment(
@recommendTreatment varchar(250),
@startedDate datetime,
@idMedicament int,
@response int output
)as
begin
	
	set @response = 0
	if not exists(select * from TREATMENT where recommendTreatment = @recommendTreatment
	and startedDate = @startedDate and idMedicament = @idMedicament)
	begin
		insert into TREATMENT values(@recommendTreatment, @startedDate, @idMedicament);
		set @response = 1
	end
end

GO

create proc SP_Update_Treatment(
@idTreatment int,
@recommendTreatment varchar(250),
@startedDate datetime,
@idMedicament int,
@response int output
)as
begin
	
	set @response = 0

	if exists (select * from TREATMENT where  idTreatment = @idTreatment)
	begin

		if not exists(select * from TREATMENT where recommendTreatment = @recommendTreatment
		and startedDate = @startedDate and idMedicament = @idMedicament and idTreatment != @idTreatment)
		begin
			update TREATMENT set 
			recommendTreatment = @recommendTreatment, 
			startedDate = @startedDate, 
			idMedicament = @idMedicament
			where idTreatment = @idTreatment
		
			set  @response = 1
		end

	end

end

GO

create proc SP_Delete_Treatment(
@idTreatment int,
@response int output
)as
begin

	set @response = 0

	if exists(select * from TREATMENT where idTreatment = @idTreatment)
	begin
		
		delete top(1) from TREATMENT where idTreatment = @idTreatment;

		set @response = 1

	end


end

GO

create proc SP_List_Treatments as
begin
	
	select tr.idTreatment, tr.recommendTreatment, m.idMedicament, m.nameMedicament,
	m.dose, m.useInstruction, tr.startedDate
	from TREATMENT tr inner join MEDICAMENT m on tr.idMedicament = m.idMedicament;

end

GO

create proc SP_Search_Treatment_By_Id(
@idTreatment int,
@response int output
)as
begin

	if exists(select * from TREATMENT where idTreatment = @idTreatment)
	begin

		select tr.idTreatment, tr.recommendTreatment, m.idMedicament, m.nameMedicament,
		m.dose, m.useInstruction, tr.startedDate
		from TREATMENT tr inner join MEDICAMENT m on tr.idMedicament = m.idMedicament
		where tr.idTreatment = @idTreatment;

	end

end

GO

-- MEDICAMENT
create proc SP_Create_Medicament(
@nameMedicament varchar(50),
@dose varchar(150),
@useInstruction varchar(250) 
)as
begin
	
	insert into MEDICAMENT values(@nameMedicament, @dose, @useInstruction)

end

GO

create proc SP_Update_Medicament(
@idMedicament int,
@nameMedicament varchar(50),
@dose varchar(150),
@useInstruction varchar(250) 
)as
begin
	
	if exists(select * from MEDICAMENT where idMedicament = @idMedicament)
	begin
		
		update MEDICAMENT set 
		nameMedicament = @nameMedicament,
		dose = @dose,
		useInstruction = @useInstruction
		where idMedicament = @idMedicament

	end

end

GO

create proc SP_Delete_Medicament(
@idMedicament int
)as
begin
	
	if exists(select * from MEDICAMENT where idMedicament = @idMedicament)
	begin
		
		delete top(1) from MEDICAMENT where idMedicament = @idMedicament;

	end
	
end

GO


create proc SP_List_Medicaments as
begin
	
	select * from MEDICAMENT;

end


GO

create proc SP_Get_Medicament_By_Id(
@idMedicament int
)as
begin

	select * from MEDICAMENT where idMedicament = @idMedicament;

end


GO

-- MEDICAMENT
create proc SP_Create_Diagnostic(
@medicalCondition varchar(250),
@registerDate datetime,
@idTreatment int,
@idDoctor int,
@idPatient int,
@idLaboratoryResult int
)as
begin

	insert into DIAGNOSTIC values(@medicalCondition, @registerDate, @idTreatment, @idDoctor, @idPatient, @idLaboratoryResult)

end

GO

create proc SP_Update_Diagnostic(
@idDiagnostic int,
@medicalCondition varchar(250),
@registerDate datetime,
@idTreatment int,
@idDoctor int,
@idPatient int,
@idLaboratoryResult int
)as
begin

	if exists(select * from DIAGNOSTIC where idDiagnostic = @idDiagnostic)
	begin
		update DIAGNOSTIC set 
		medicalCondition = @medicalCondition, 
		registerDate = @registerDate, 
		idTreatment = @idTreatment, 
		idDoctor = @idDoctor, 
		idPatient = @idPatient, 
		idLaboratoryResult = @idLaboratoryResult
		where idDiagnostic = @idDiagnostic;
	end

end

GO

create proc SP_Delete_Diagnostic(
@idDiagnostic int
)as
begin
	
	if exists(select * from Diagnostic where idDiagnostic = @idDiagnostic)
	begin

		delete top(1) from DIAGNOSTIC where idDiagnostic = @idDiagnostic;

	end

end

GO

create proc SP_List_Diagnostics as
begin

	select dg.idDiagnostic, dg.medicalCondition, tr.idTreatment, tr.recommendTreatment,
	d.idDoctor, concat(d.nameDoctor, ' ',d.middleName, ' ',d.lastName) as 'nameDoctor', 
	p.idPatient, concat(p.namePatient, ' ', p.middleName, ' ', p.lastName) as 'namePatient',
	lr.idLaboratoryResult, lr.test, lr.resultValue, lr.dateDone
	from Diagnostic dg inner join TREATMENT tr on tr.idTreatment = dg.idTreatment
	inner join DOCTOR d on d.idDoctor = dg.idDoctor 
	inner join PATIENT p on p.idPatient = dg.idPatient
	inner join LABORATORY_RESULT lr on lr.idLaboratoryResult = dg.idLaboratoryResult;

end

GO

create proc SP_Search_Diagnostic_By_Id(
@idDiagnostic int
)as
begin

	select dg.idDiagnostic, dg.medicalCondition, tr.idTreatment, tr.recommendTreatment,
	d.idDoctor, concat(d.nameDoctor, ' ',d.middleName, ' ',d.lastName) as 'nameDoctor', 
	p.idPatient, concat(p.namePatient, ' ', p.middleName, ' ', p.lastName) as 'namePatient',
	lr.idLaboratoryResult, lr.test, lr.resultValue, lr.dateDone
	from Diagnostic dg inner join TREATMENT tr on tr.idTreatment = dg.idTreatment
	inner join DOCTOR d on d.idDoctor = dg.idDoctor 
	inner join PATIENT p on p.idPatient = dg.idPatient
	inner join LABORATORY_RESULT lr on lr.idLaboratoryResult = dg.idLaboratoryResult
	where dg.idDiagnostic = @idDiagnostic;

end

GO

create proc SP_Create_Lab_Result(
@test varchar(150),
@resultValue varchar(150),
@dateDone datetime
)as
begin
	
	insert into LABORATORY_RESULT values(@test, @resultValue, @dateDone);

end

GO

create proc SP_Update_Lab_Result(
@idLaboratoryResult int,
@test varchar(150),
@resultValue varchar(150),
@dateDone datetime
)as
begin
	
	if exists(select * from LABORATORY_RESULT where idLaboratoryResult = @idLaboratoryResult)
	begin
		
		update LABORATORY_RESULT set
		test = @test,
		resultValue = @resultValue, 
		dateDone = @dateDone
		where idLaboratoryResult = @idLaboratoryResult;

	end

end

GO

create proc SP_Delete_Lab_Result(
@idLabResult int
)as
begin

	if exists(select * from LABORATORY_RESULT where idLaboratoryResult = @idLabResult)
	begin
		delete top(1) from LABORATORY_RESULT where idLaboratoryResult = @idLabResult;
	end

end

GO

create proc SP_List_Lab_Results as
begin
	
	select * from LABORATORY_RESULT;

end

GO

create proc SP_Get_LabResult_By_Id(
@idLabResult int
)as
begin

	select * from LABORATORY_RESULT where idLaboratoryResult = @idLabResult;

end

GO

-- DOCTOR
create proc SP_Create_Doctor(
@nameDoctor varchar(60),
@middleName varchar(50),
@lastName varchar(50),
@birthDate datetime,
@telephone varchar(15),
@idAddress int,
@response int output
)as
begin
	
	set @response = 0

	if not exists(select * from DOCTOR where nameDoctor = @nameDoctor and middleName = @middleName and lastName = @lastName and birthDate = @birthDate and telephone= @telephone and idAddress = @idAddress)
		begin

			insert into Doctor values(@nameDoctor, @middleName, @lastName, @birthDate, @telephone, @idAddress)	
			set @response = SCOPE_IDENTITY()
		end
end

GO

create proc SP_Update_Doctor(
@idDoctor int,
@nameDoctor varchar(60),
@middleName varchar(50),
@lastName varchar(50),
@birthDate datetime,
@telephone varchar(15),
@idAddress int,
@response int output
)as
begin
	
	set @response = 0

	if exists(select * from Doctor where idDoctor = @idDoctor)
	begin

		if not exists(select * from Doctor where nameDoctor = @nameDoctor and middleName = @middleName and lastName = @lastName and birthDate = @birthDate and telephone = @telephone and idAddress = @idAddress and idDoctor != @idDoctor)
		begin

			update Doctor set 
			nameDoctor = @nameDoctor, 
			middleName = @middleName, 
			lastName = @lastName, 
			birthDate = @birthDate, 
			telephone = @telephone, 
			idAddress = @idAddress
			where idDoctor = @idDoctor

			set @response = 1
		end

	end
end

GO

create proc SP_Delete_Doctor(
@idDoctor int,
@response int output
)as
begin
	
	set @response = 0

	if exists(select * from DOCTOR where idAddress = @idDoctor)
	begin
		delete top(1) from DOCTOR where idDoctor = @idDoctor;
		set @response = 1
	end

end

GO

create proc SP_List_Doctors as
begin

	select d.idDoctor, d.nameDoctor, d.middleName, d.lastName, d.birthDate, d.telephone,
	ad.idAddress, ad.street, ad.suburb, ad.city, ad.[state]
	from DOCTOR d inner join [ADDRESS] ad on ad.idAddress = d.idAddress;

end

GO

create proc SP_Search_Doctor_By_Id(
@idDoctor int
)as
begin 

	select d.idDoctor, d.nameDoctor, d.middleName, d.lastName, d.birthDate, d.telephone,
	ad.idAddress, ad.street, ad.suburb, ad.city, ad.[state]
	from DOCTOR d inner join [ADDRESS] ad on ad.idAddress = d.idAddress
	where idDoctor = @idDoctor;

end

GO

SELECT * FROM TREATMENT

GO


CREATE PROC SP_Get_Expedient_Patient_By_Id(
@idPatient int,
@namePatient varchar(250) output,
@medicalCondition varchar(150) = null output,
@treatment varchar(200) = null output,
@test varchar(200) = null output,
@testResult varchar(250) = null output,
@medicament varchar(200) = null output,
@doctor varchar(250) = null output,
@registerDate varchar(250) = null output
)as
begin

	select @namePatient = CONCAT(p.namePatient, ' ', p.middleName, ' ', p.lastName), 
	@medicalCondition = dg.medicalCondition, 
	@treatment = t.recommendTreatment,
	@test = lr.test, 
	@testResult =  lr.resultValue, 
	@medicament = md.nameMedicament,
	@doctor = CONCAT(d.nameDoctor, ' ', d.middleName, ' ', d.lastName), 
	@registerDate = registerDate
	from PATIENT p inner join DIAGNOSTIC dg on p.idPatient = dg.idPatient  inner join 
	DOCTOR d on d.idDoctor = dg.idDoctor 	inner join LABORATORY_RESULT lr on lr.idLaboratoryResult = dg.idLaboratoryResult
	inner join TREATMENT t on t.idTreatment = dg.idTreatment inner join MEDICAMENT md on md.idMedicament = t.idMedicament
	where p.idPatient = @idPatient

	return;

end

GO

CREATE PROC SP_Create_Recipe(
@namePatient varchar(250),
@medicalCondition varchar(150),
@treatment varchar(200),
@test varchar(200),
@testResult varchar(250),
@medicament varchar(200),
@doctor varchar(250),
@registerDate datetime,
@idPatient int,
@response int output
)AS
BEGIN
	
	set @response = 0

	if not exists(select * from RECIPE where namePatient = @namePatient and 
	medicalCondition = @medicalCondition and treatment = @treatment and test = @test and testResult = @testResult
	 and medicament = @medicament and doctor = @doctor and registerDate = @registerDate and idPatience != @idPatient)
		begin

			INSERT INTO RECIPE VALUES(@namePatient, @medicalCondition, @treatment, @test, @testResult, @medicament, @doctor, @registerDate, @idPatient)
			
			set @response = SCOPE_IDENTITY()

		end
END

GO

create proc SP_Get_All_Recipes as
begin

	select r.idRecipe, r.medicalCondition, r.treatment, 
	r.test, r.testResult, r.medicament, r.doctor, r.registerDate, p.idPatient, p.namePatient
	from RECIPE r inner join PATIENT p on p.idPatient = r.idPatience;

end

GO


create proc SP_Get_Recipe_By_Id(
@idRecipe int
)as
begin

	select r.idRecipe, r.medicalCondition, r.treatment, 
	r.test, r.testResult, r.medicament, r.doctor, r.registerDate, p.idPatient, p.namePatient
	from RECIPE r inner join PATIENT p on p.idPatient = r.idPatience 
	where idRecipe = @idRecipe;

end

GO

CREATE TRIGGER trg_Create_Recipe
ON DIAGNOSTIC
AFTER INSERT, UPDATE 
AS BEGIN

	DECLARE @idDiagnostic varchar(250);
	DECLARE @idPatient int;
	DECLARE @namePatient varchar(250);
	DECLARE	@medicalCondition varchar(150);
	DECLARE	@treatment varchar(200);
	DECLARE	@test varchar(200);
	DECLARE	@testResult varchar(250);
	DECLARE	@medicament varchar(200);
	DECLARE	@doctor varchar(250);
	DECLARE	@registerDate varchar(250);

	SELECT TOP(1) @idDiagnostic = idDiagnostic FROM DIAGNOSTIC ORDER BY idDiagnostic DESC;
	
	SELECT @idPatient = idPatient FROM DIAGNOSTIC WHERE idDiagnostic = @idDiagnostic;

	EXEC SP_Get_Expedient_Patient_By_Id @idPatient = @idPatient, 
	@namePatient = @namePatient output, @medicalCondition = @medicalCondition output,
	@treatment = @treatment output, @test = @test output, @testResult = @testResult output,
	@medicament = @medicament output, @doctor = @doctor output, @registerDate = @registerDate output

	EXEC SP_Create_Recipe @namePatient = @namePatient, @medicalCondition = @medicalCondition,
	@treatment = @treatment, @test = @test, @testResult = @testResult, @medicament = @medicament,
	@doctor = @doctor, @registerDate = @registerDate, @idPatient = @idPatient

END


GO
--- TRIGGERS
-- LABORATORY RESULT
CREATE TRIGGER trg_Default_Date_Lab_Result
ON LABORATORY_RESULT
AFTER INSERT
AS
BEGIN
    UPDATE LABORATORY_RESULT
    SET dateDone = ISNULL(dateDone, GETDATE())
    WHERE idLaboratoryResult IN (SELECT idLaboratoryResult FROM inserted);
END;


GO

--- DOCTOR
CREATE TRIGGER trg_Unique_Doctor_Telephone
ON DOCTOR
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT telephone FROM DOCTOR GROUP BY telephone HAVING COUNT(*) > 1)
    BEGIN
        RAISERROR ('Telephone number must be unique', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;

GO

CREATE TRIGGER trg_Prevent_Doctor_Deletion
ON DOCTOR
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (SELECT * FROM DOCTOR WHERE idDoctor IN (SELECT idDoctor FROM deleted))
    BEGIN
        RAISERROR ('Cannot delete address linked to a doctor', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    ELSE
    BEGIN
        DELETE FROM DOCTOR WHERE idDoctor IN (SELECT idDoctor FROM deleted);
    END
END;

GO

-- PATIENT
CREATE TRIGGER trg_Log_Patient_Deletion
ON PATIENT
AFTER DELETE
AS
BEGIN
    INSERT INTO Patient_Log (Operation, PatientID, Name, MiddleName, LastName, BirthDate, ChangeDate)
    SELECT 'DELETE', idPatient, namePatient, middleName, lastName, birthDate, GETDATE()
    FROM deleted;
END;

GO


USE HOSPITAL;

GO

-- ADDRESS
CREATE TRIGGER trg_Prevent_Address_Deletion
ON [ADDRESS]
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (SELECT * FROM PATIENT WHERE idAddress IN (SELECT idAddress FROM deleted))
    BEGIN
        RAISERROR ('Cannot delete address linked to a patient', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    ELSE
    BEGIN
        DELETE FROM [ADDRESS] WHERE idAddress IN (SELECT idAddress FROM deleted);
    END
END;

GO

-- INSERTIONS OF ROW REGISTER
-- ADDRESS
SELECT * FROM [ADDRESS]
INSERT INTO [ADDRESS] VALUES('123 Main St','Greenfield','Springfield','Illinois')
INSERT INTO [ADDRESS] VALUES('456 Elm St','Lakeside','Chicago','Illinois')
INSERT INTO [ADDRESS] VALUES('789 Oak St','Midtown','New York','New York')
INSERT INTO [ADDRESS] VALUES('101 Maple St','Downtown','Los Angeles','California')

INSERT INTO [ADDRESS] VALUES('234 Pine St', 'Riverdale', 'Houston', 'Texas')
INSERT INTO [ADDRESS] VALUES('567 Cedar Ave',	'West Hills', 'San Diego', 'California')
INSERT INTO [ADDRESS] VALUES('890 Birch Blvd', 'Eastview', 'Seattle',	'Washington')
INSERT INTO [ADDRESS] VALUES('321 Willow Lane', 'Brookside', 'Miami',	'Florida')

GO

-- DOCTOR
SELECT * FROM DOCTOR;
INSERT INTO DOCTOR VALUES('John', 'Michael',  'Smith', '1985-06-15', '555-123-4567', 2)
INSERT INTO DOCTOR VALUES('Emily',	'Rose',	'Johnson', '1990-09-24', '555-234-5678', 4)
INSERT INTO DOCTOR VALUES('William', 'Alexander', 'Brown', '1978-11-10', '555-345-6789', 3)
INSERT INTO DOCTOR VALUES('Olivia',	'Grace', 'Davis', '2000-03-05', '555-456-7890', 1)
-- INSERT INTO DOCTOR VALUES('Daniel',	'Lee', 'Martinez', '1983-01-22', '555-567-8901')

GO

-- PATIENT
SELECT * FROM PATIENT;
INSERT INTO PATIENT VALUES('Sophia', 'Marie', 'Hernandez', '1988-07-21', '555-678-1234', 8)
INSERT INTO PATIENT VALUES('James',	'Edward', 'Garcia',	'1995-12-11', '555-789-2345', 6)
INSERT INTO PATIENT VALUES('Isabella', 'Rose', 'Martinez', '1982-02-14', '555-890-3456', 5)
INSERT INTO PATIENT VALUES('Mia', 'Grace', 'Anderson', '1993-03-23', '555-012-5678', 7)
-- INSERT INTO PATIENT VALUES()

GO

-- 
GO
SELECT * FROM MEDICAMENT;

INSERT INTO MEDICAMENT VALUES('Amoxicilina', '500 mg', 'Tomar una tableta tres veces al dia durante diez dias.')
INSERT INTO MEDICAMENT VALUES('Doxicilina', '100 mg', 'Tomar una tableta dos veces al dia durante siete dias. ')
INSERT INTO MEDICAMENT VALUES('Ciclofosfamida', '600 mg/m2', 'Administrar intravenosa durante 60 minutos, una vez cada tres semanas.')
INSERT INTO MEDICAMENT VALUES('Doxorrubicina', '60 mg/m2', 'Administrar intravenosa durante 48 horas, una vez cada tres semanas.')
INSERT INTO MEDICAMENT VALUES('Ibuprofeno', '400 mg', 'Tomar una tableta cada 4-6 horas, no exeder tres tabletas en un dia.')
INSERT INTO MEDICAMENT VALUES('Aceteminofén', '500 mg', 'Tomar una tableta cada 4-6 horas, no exeder dos tabletas en un dia.')
INSERT INTO MEDICAMENT VALUES('Glargina Insulina', '100 units/mL', 'Inyectar 0.2 ml subcutaneamente una vez al dia, a la misma hora cada dia. ')
INSERT INTO MEDICAMENT VALUES('Lispo Insulina', '100 units/mL', 'Inyectar 0.1 - 0.2 ml subcutaneamente antes de la comida, dependiendo de los niveles de azucar en la sangre.')

GO

SELECT * FROM TREATMENT;

INSERT INTO TREATMENT VALUES('Antibioticos', '2024-01-10',2)
INSERT INTO TREATMENT VALUES('Terapia fisica', '2024-02-15',5)
INSERT INTO TREATMENT VALUES('Quimioterapia', '2024-03-20',4)
INSERT INTO TREATMENT VALUES('Terapia de insulina', '2024-04-25',8)

GO

INSERT INTO LABORATORY_RESULT VALUES('Conteo sanguíneo completo.', 'WBC: 7,500/mm³, RBC: 4.5 million/mm³, Hemoglobin: 14 g/dL', '2024-12-10')
INSERT INTO LABORATORY_RESULT VALUES('Ionograma.', 'Sodium: 140 mEq/L, Potassium: 4.2 mEq/L, Calcium: 9.5 mg/dL', '2024-12-11')
INSERT INTO LABORATORY_RESULT VALUES('Conteo sanguíneo completo.', 'WBC: 3,000/mm³, RBC: 3.8 million/mm³, Hemoglobin: 10 g/dL', '2024-12-12')
INSERT INTO LABORATORY_RESULT VALUES('Prueba de funcion de higado.', 'ALT: 50 U/L, AST: 45 U/L, Bilirubin: 1.2 mg/dL', '2024-12-13')
INSERT INTO LABORATORY_RESULT VALUES('Examen de nitrógeno ureico en la sangre (BUN).', '20 mg/dL', '2024-12-14')
INSERT INTO LABORATORY_RESULT VALUES('Creatinina.', '1.1 mg/dL', '2024-12-15')
INSERT INTO LABORATORY_RESULT VALUES('Prueba de sensibilidad antibiotica.', 'Sensibilidad a la amoxicilina, resistencia a la penicilina.', '2024-12-16')
INSERT INTO LABORATORY_RESULT VALUES('Cultivo de sangre.', 'Sin crecimiento bacterial detectado.', '2024-12-17')
INSERT INTO LABORATORY_RESULT VALUES('Glucemia en ayunas.', '95 mg/dL', '2024-12-18')
INSERT INTO LABORATORY_RESULT VALUES('Prueba de hemoglobina glicosilada (HbA1c).', '6.5%', '2024-12-19')
INSERT INTO LABORATORY_RESULT VALUES('Prueba de tolerancia oral a la glucosa.', '140 mg/dL after 2 hours', '2024-12-20')
INSERT INTO LABORATORY_RESULT VALUES('Prueba aleatoria de azucar en la sangre.', '160 mg/dL', '2024-12-21')


INSERT INTO DIAGNOSTIC VALUES('Alta ingesta de proteínas', '2024-12-26', 3, 2, 1, 5)
INSERT INTO DIAGNOSTIC VALUES('Balance normal de electrolitos', '2024-12-28', 2, 1, 3, 2)
INSERT INTO DIAGNOSTIC VALUES('Tratamiento efectivo con amoxicilina, inefectivo con penicilina.', '2024-12-27', 1, 3, 4, 8)
INSERT INTO DIAGNOSTIC VALUES('Normal', '2024-12-28', 4, 2, 2, 12)
INSERT INTO DIAGNOSTIC VALUES('Deshidratación', '2024-12-28', 2, 1, 1,5)

use HOSPITAL;


SELECT * FROM [ADDRESS];
SELECT * FROM DIAGNOSTIC;
SELECT * FROM DOCTOR;
SELECT * FROM LABORATORY_RESULT;
SELECT * FROM MEDICAMENT;
SELECT * FROM PATIENT;
SELECT * FROM TREATMENT;
SELECT * FROM RECIPE;


SELECT dg.medicalCondition, (SELECT p.namePatient FROM PATIENT p WHERE p.idPatient = dg.idPatient) AS 'Nombre paciente'
FROM DIAGNOSTIC dg

GO

create proc SP_Verify_LabResult_Linked_With_Diagnostic(
@idLabResult int
)as
begin

	select dg.idDiagnostic, dg.medicalCondition, tr.idTreatment, tr.recommendTreatment,
	d.idDoctor, concat(d.nameDoctor, ' ',d.middleName, ' ',d.lastName) as 'nameDoctor', 
	p.idPatient, concat(p.namePatient, ' ', p.middleName, ' ', p.lastName) as 'namePatient',
	lr.idLaboratoryResult, lr.test, lr.resultValue, lr.dateDone
	from Diagnostic dg inner join TREATMENT tr on tr.idTreatment = dg.idTreatment
	inner join DOCTOR d on d.idDoctor = dg.idDoctor 
	inner join PATIENT p on p.idPatient = dg.idPatient
	inner join LABORATORY_RESULT lr on lr.idLaboratoryResult = dg.idLaboratoryResult
	where dg.idLaboratoryResult = @idLabResult;

end


GO

create proc SP_Verify_Doctor_Linked_With_Diagnostic(
@idDoctor int
)as
begin

	select dg.idDiagnostic, dg.medicalCondition, tr.idTreatment, tr.recommendTreatment,
	d.idDoctor, concat(d.nameDoctor, ' ',d.middleName, ' ',d.lastName) as 'nameDoctor', 
	p.idPatient, concat(p.namePatient, ' ', p.middleName, ' ', p.lastName) as 'namePatient',
	lr.idLaboratoryResult, lr.test, lr.resultValue, lr.dateDone
	from Diagnostic dg inner join TREATMENT tr on tr.idTreatment = dg.idTreatment
	inner join DOCTOR d on d.idDoctor = dg.idDoctor 
	inner join PATIENT p on p.idPatient = dg.idPatient
	inner join LABORATORY_RESULT lr on lr.idLaboratoryResult = dg.idLaboratoryResult
	where dg.idDoctor = @idDoctor;

end

GO


create proc SP_Verify_Medicament_Linked_With_Treatment(
@idMedicament int
)as
begin

		select tr.idTreatment, tr.recommendTreatment, m.idMedicament, m.nameMedicament,
		m.dose, m.useInstruction, tr.startedDate
		from TREATMENT tr inner join MEDICAMENT m on tr.idMedicament = m.idMedicament
		where tr.idMedicament = @idMedicament;

end

GO




