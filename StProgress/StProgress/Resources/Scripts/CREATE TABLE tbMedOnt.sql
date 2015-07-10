CREATE TABLE tbMedOnt
(
	StudentID	int		FOREIGN KEY REFERENCES tbStudent(StudentID),
	HTML		varchar(5),
	HTML5		varchar(5),
	PHP			varchar(5),
	MYSQL		varchar(5),
);