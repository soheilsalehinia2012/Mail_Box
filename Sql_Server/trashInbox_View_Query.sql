create view trashInbox as
select * from Messages,Users 
where Messages.SenderID = Users.UserName
and Messages.delFlagInbox = 1