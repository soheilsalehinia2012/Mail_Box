create procedure showTrashSent
@userName varchar(20)
as
Select MID,Subject,Text,readFlag,ReceiverID,UserName,Name,FamilyName  from trashSent where SenderID = @userName