CREATE TABLE tbStudent
(
	StudentID		int				identity(1,1)		PRIMARY KEY,
	OV_ID			varchar(25)							NOT NULL,
	Firstname		varchar(50)							NOT NULL,
	Surname			varchar(50)							NOT NULL,	
	Age				int									NOT NULL,
	Phonenumber		int,
	Startdate		datetime							NOT NULL							
);