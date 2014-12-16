create procedure saveUser
@username varchar(20),
@password varchar(20),
@name nvarchar(15),
@fname nvarchar(20)
as
insert into Users values (@username,@password,@name,@fname)