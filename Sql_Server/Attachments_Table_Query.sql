create table Attachments(
	AID int identity primary key,
	AttachedFile image not null,
	MID int foreign key references Messages(MID) not null,
	description nvarchar(500)
)