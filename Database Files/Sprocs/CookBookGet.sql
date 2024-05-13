use RecipeDB
go

create or alter procedure dbo.CookBookGet(
	@CookBookId int = 0,
	@CookBookActive bit = 0,
	@All bit = 0
)
as
begin
	
	select @CookBookActive = isnull(@CookBookActive,0), @CookBookId = isnull(@CookBookId, 0)

	select CookBookId = c.cookbookid, c.CookBookName, u.usersid, UserName = concat(u.firstname, ' ', u.LastName), c.Price, CookBookActive = c.CookBookActive, DateBookCreated = c.DateBookCreated, IsDeleteAllowed = dbo.IsDeleteAllowed(c.cookbookid)	
	from CookBooks c
	join users u 
	on u.Usersid = c.UsersId
	where c.cookbookid = @CookBookId
	or @All = 1
		
end
go

--exec CookBookGet @All = 1
