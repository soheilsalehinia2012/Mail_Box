create procedure showTrashInbox
@userName varchar(20)
as
Select MID,Subject,Text,readFlag,SenderID,UserName,Name,FamilyName  from trashInbox where ReceiverID = @userName