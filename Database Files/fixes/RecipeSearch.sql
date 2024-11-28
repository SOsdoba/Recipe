create or alter procedure dbo.RecipeSearch(
	@CookBookName varchar(50) = '',
	@All int = 1,
	@Message varchar(1000) = '' output
)
as 
begin

	select @CookBookName = isnull(@CookBookName,'')	

	select r.RecipeId, c.cookbookid, r.recipename, r.usersid, u.username, r.calories, NumIngredients = count(ri.recipeid), r.vegan, r.recipestatus, r.CuisineTypeId, r.recipepicture
	from recipe r
	join CookBookRecipes cr 
	on r.recipeid = cr.recipeid
	join cookbooks c
	on c.cookbookid = cr.cookbookid
	join users u
	on u.usersid = r.usersid 
	join RecipeIngredient ri
	 on ri.recipeid = r.recipeid
	where c.cookbookname = @CookBookName
	group by r.RecipeId, c.cookbookid, r.recipename, r.usersid, u.username, r.calories, r.vegan, r.recipestatus, r.CuisineTypeId, r.recipepicture

end 
go
--exec RecipeSearch
--exec RecipeSearch @CookBookName = 'Whip-It-Up'
select * from cookbooks

