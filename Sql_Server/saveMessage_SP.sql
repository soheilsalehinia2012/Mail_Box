create procedure saveMessage
@subject nvarchar(20),
@text nvarchar(2000),
@senderuser varchar(20),
@receiveruser varchar(20),
@attach1 image,
@des1 nvarchar(500),
@attach2 image,
@des2 nvarchar(500),
@attach3 image,
@des3 nvarchar(500)
as
insert into Messages(Subject,Text,readFlag,SenderID,ReceiverID,delFlagInbox,delFlagSent) values 
(@subject,@text,0,@senderuser,@receiveruser,0,0)

insert into Attachments(AttachedFile,MID,description) values (@attach1,(select @@IDENTITY from Messages),@des1)