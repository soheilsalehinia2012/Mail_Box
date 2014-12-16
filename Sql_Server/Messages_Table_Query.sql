create table Messages(
	MID int identity primary key,
	Subject Nvarchar(20),
	Text Nvarchar(2000),
	readFlag bit not null,
	SenderID varchar(20) foreign key references Users(UserName) not null,
	ReceiverID varchar(20) foreign key references Users(UserName) not null,
	delFlagInbox bit not null,
	delFlagSent bit not null
	)