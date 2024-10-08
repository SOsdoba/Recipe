update Cookbooks set CookBookSkill = 1
where CookBookName = 'The Dessert Table'
update Cookbooks set CookBookSkill = 2
where CookBookName = 'Whip-It-Up'
update Cookbooks set CookBookSkill = 3
where CookBookName = 'The Table'
update Cookbooks set CookBookSkill = 3
where CookBookName = 'Tasty'
update Cookbooks set CookBookSkill = 2
where CookBookName = 'Treats for Two'
select * from cookbooks
use RecipeDB
go

create or alter procedure dbo.CookBookGet(
	@CookBookId int = 0,
	@All bit = 0
)
as
begin
	
	select @CookBookId = isnull(@CookBookId, 0)

	select c.cookbookid, c.CookBookName, u.usersid, UserName = concat(u.firstname, ' ', u.LastName), NumRecipes = count(distinct r.recipeid),  c.Price, c.CookBookActive,  c.DateBookCreated, c.CookBookPicture, c.CookbookSkillDesc
	from CookBooks c
	join users u 
	on u.Usersid = c.UsersId
	left join CookBookRecipes r
	on r.CookBookId = c.CookBookId
	where c.cookbookid = @CookBookId
	or @All = 1
	group by c.CookBookId, u.usersid, c.CookBookActive, c.DateBookCreated, c.CookBookName, u.FirstName, u.LastName, c.Price, c.CookBookPicture, c.CookbookSkillDesc
	order by c.CookBookName
end
go

--exec CookBookGet @All = 1

