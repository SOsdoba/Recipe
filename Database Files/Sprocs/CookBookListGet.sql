use RecipeDB
go
create or alter procedure dbo.CookBookListGet(@CookBookId int = 0, @All bit = 0)
as
begin
	select c.cookbookid, CookBookName = c.cookbookname, Author = concat(u.firstname, ' ', u.lastname), NumRecipes = count(distinct r.recipeid), c.Price 
	from cookbooks c
	join users u
	on u.usersid = c.usersid
	left join CookBookRecipes r
	on r.CookBookId = c.CookBookId
	where c.CookBookId = @CookBookId
	or @All = 1
	group by c.CookBookId, c.CookBookName, u.FirstName, u.LastName, c.Price
	order by c.CookBookName
	end
go

exec CookBookListGet @All = 1



