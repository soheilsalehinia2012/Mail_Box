create procedure verifyUser
@userName varchar(20),
@password varchar(20)
as
select COUNT(UserName) from Users where UserName = @userName and PassWord = @password
--if >= 0 then user verified..