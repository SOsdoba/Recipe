create or alter procedure dbo.CookBookRecipesUpdate(
	@CookBookRecipesId int output,
	@CookBookId int,
	@RecipeId int,
	@CookBookRecipeSequence int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookBookRecipesId = isnull(@CookBookRecipesId,0)

	if @CookBookRecipesId = 0
	begin 
		insert CookBookRecipes(CookBookId, RecipeId, CookBookRecipeSequence)
		values(@CookBookId, @RecipeId, @CookBookRecipeSequence)

		select @CookBookRecipesId = scope_identity()
	end
	else
	begin
		update CookBookRecipes
		set
			CookBookId = @CookBookId,
			RecipeId = @RecipeId,
			CookBookRecipeSequence = @CookBookRecipeSequence
		where CookBookRecipesId = @CookBookRecipesId
	end

	return @return
end
go