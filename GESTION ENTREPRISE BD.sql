
	create database GESTION_ENTREPRISE

	go
	use GESTION_ENTREPRISE
	go
	create table Employé 
	(
	NumEmployé int primary key,
	NomEmployé varchar(30),
	PrenomEmployé varchar(30),
	SexeEmployé varchar(30),
	DNaissEmployé date,
	FonctionEmployé varchar(30)
	)
	go
	create table Inscription (
	NumEmployé int foreign key references Employé(NumEmployé) , 
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

	
			select * from employé
			select * from TypeProjet
			select * from projet 
			insert into projet values (1,'commerce','2021-04-12','2021-04-15')