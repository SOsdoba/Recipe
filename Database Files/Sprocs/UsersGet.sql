use RecipeDB
go
create or alter procedure dbo.UsersGet(@UsersId int = 0, @All bit = 0, @FirstName varchar(50) = '')
as 
begin
	select u.usersid, u.firstname, u.lastname, u.username
	from users u
	where u.usersid = @usersid
	or @All = 1
	or (@firstname <> '' and u.firstname like '%' + @firstname + '%')
end
go
/*
exec UsersGet
exec UsersGet @All = 1

exec UsersGet @FirstName = ''
exec UsersGet @FirstName = 'a'
exec UsersGet @FirstName = null

declare @Usersid int
select top 1 @Usersid = u.usersid from users u
exec UsersGet @Usersid = @Usersid




*/