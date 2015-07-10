CREATE TABLE tbAlg
(
	StudentID	int		FOREIGN KEY REFERENCES tbStudent(StudentID),	
	PVB			varchar(5),
	NE			varchar(5),
	ENG			varchar(5),
	REK			varchar(5),
	LWH			varchar(5),	
	UML			varchar(5),
	NORM		varchar(5),
);