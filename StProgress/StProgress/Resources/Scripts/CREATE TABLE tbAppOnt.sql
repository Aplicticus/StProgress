CREATE TABLE tbAppOnt
(
	StudentID	int		FOREIGN KEY REFERENCES tbStudent(StudentID),	
	MTA_SDF		varchar(5),
	MTA_NET		varchar(5),
	MTA_WDF		varchar(5),

	MOS			varchar(5),	 /* wat voor vakken zijn dit? */
	SECU		varchar(5),  /* wat voor vakken zijn dit? */
);