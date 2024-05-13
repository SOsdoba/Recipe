create or alter proc dbo.CookBookRecipesDelete(
	@CookBookRecipesId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	delete CookBookRecipes where CookBookRecipesId = @CookBookRecipesId

	return @return
end
go

