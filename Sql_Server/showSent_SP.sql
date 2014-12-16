create procedure showSent
@userName varchar(20)
as
Select MID,Subject,Text,readFlag,ReceiverID,UserName,Name,FamilyName  from sent where SenderID = @userName