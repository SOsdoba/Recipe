use RecipeDB
go

create or alter procedure dbo.CookBookGet(
	@CookBookId int = 0,
	@All bit = 0
)
as
begin
	
	select @CookBookId = isnull(@CookBookId, 0)

	select c.cookbookid, c.CookBookName, u.usersid, UserName = concat(u.firstname, ' ', u.LastName), NumRecipes = count(distinct r.recipeid),  c.Price, c.CookBookActive,  c.DateBookCreated
	from CookBooks c
	join users u 
	on u.Usersid = c.UsersId
	left join CookBookRecipes r
	on r.CookBookId = c.CookBookId
	where c.cookbookid = @CookBookId
	or @All = 1
	group by c.CookBookId, u.usersid, c.CookBookActive, c.DateBookCreated, c.CookBookName, u.FirstName, u.LastName, c.Price
	order by c.CookBookName
end
go

--exec CookBookGet @All = 1
