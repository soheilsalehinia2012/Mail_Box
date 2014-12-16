create view sent as
select * from Messages,Users 
where Messages.ReceiverID = Users.UserName
and Messages.delFlagSent = 0
