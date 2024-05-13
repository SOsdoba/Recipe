use RecipeDB
go
create or alter procedure dbo.UsersGet(@UsersId int = 0, @UserName varchar(50) = '', @All bit = 0, @IncludeBlank bit = 0)
as 
begin
	select u.usersid, FirstName = u.firstname, LastName = u.lastname, UserName = u.username
	from users u
	where u.usersid = @UsersId
	or (@UserName <> '' and u.username like '%' + @UserName + '%')
	or @All = 1
	union select 0, ' ', ' ', ' '
	where @IncludeBlank = 1
	order by u.Username
end
go

/*
exec UsersGet
exec UsersGet @All = 1

exec UsersGet @UserName = ''
exec UsersGet @UserName = 'a'
exec UsersGet @UserName = null

declare @UsersId int
select top 1 @UsersId = u.usersid from users u
exec UsersGet @UsersId = @UsersId




*/