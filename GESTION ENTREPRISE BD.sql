
	create database GESTION_ENTREPRISE

	go
	use GESTION_ENTREPRISE
	go
	create table Employ� 
	(
	NumEmploy� int primary key,
	NomEmploy� varchar(30),
	PrenomEmploy� varchar(30),
	SexeEmploy� varchar(30),
	DNaissEmploy� date,
	FonctionEmploy� varchar(30)
	)
	go
	create table Inscription (
	NumEmploy� int foreign key references Employ�(NumEmploy�) , 
	CodeProjet int foreign key references Projet(CodeProjet), 
	dateiscription date 
	)
	go
	create table Projet(
	 CodeProjet int primary key ,
	 TypeProjet varchar(20) foreign key references TypeProjet(TypeProjet), 
	 DateDebut date, 
	 DateFin date
	 )
	 go
	create table TypeProjet
	(
	TypeProjet varchar(20) primary key , 
	libelleProjet varchar(30), 
	DureeProjet date 
	)

	
			select * from employ�
			select * from TypeProjet
			select * from projet 
			insert into projet values (1,'commerce','2021-04-12','2021-04-15')