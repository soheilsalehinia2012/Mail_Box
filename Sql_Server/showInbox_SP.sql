create procedure showInbox
@userName varchar(20)
as
Select MID,Subject,Text,readFlag,SenderID,UserName,Name,FamilyName  from inbox where ReceiverID = @userName