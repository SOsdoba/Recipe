create or alter proc dbo.CloneRecipe(
	@RecipeId int = null output,
	@BaseRecipeId int,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

		insert Recipe(UsersId, CuisineTypeId, RecipeName,Calories, DraftDate, PublishDate, ArchiveDate)
		select r.UsersId, r.CuisineTypeId, RecipeName = concat(r.RecipeName, ' - clone'), r.Calories, r.DraftDate, r.PublishDate, r.ArchiveDate
		from Recipe r
		where r.recipeid = @BaseRecipeId
	
		select @RecipeId = SCOPE_IDENTITY()

		insert Directions(RecipeId, Direction, SequenceOfDirections)
		select @RecipeId, d.Direction, d.SequenceOfDirections
		from Directions d
		where d.recipeid = @BaseRecipeId

		insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, SequenceOfIngredients)
		select @RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.Amount, ri.SequenceOfIngredients
		from RecipeIngredient ri
		where ri.recipeid = @BaseRecipeId
	  
	return @return
end
go


--declare
--	@RecipeId int,
--	@UsersId int,
--	@CuisineTypeId int,
--	@RecipeName varchar(40),
--	@Calories int,
--	@DraftDate datetime,
--	@PublishDate datetime,
--	@ArchiveDate datetime,
--	@BaseRecipeId int,
--	@i int,
--	@m varchar(500)

--select top 1 @BaseRecipeId = r.recipeid, 
--		@UsersId = r.UsersId, 
--		@CuisineTypeId = r.CuisineTypeId,
--		@RecipeName = concat(r.recipename, ' - clone'),
--		@Calories = r.calories,
--		@DraftDate = r.DraftDate,
--		@PublishDate = r.PublishDate,
--		@ArchiveDate = r.ArchiveDate
--		from recipe r order by r.recipeid

--exec @i = CloneRecipe
--	@RecipeId = @RecipeId output,
--	@UsersId = @UsersId, 
--	@CuisineTypeId = @CuisineTypeId,
--	@RecipeName = @RecipeName,
--	@Calories = @Calories,
--	@DraftDate = @DraftDate,
--	@PublishDate = @PublishDate,
--	@ArchiveDate = @ArchiveDate,
--	@BaseRecipeId = @BaseRecipeId,
--	@Message = @m output

--select @i, @m

--select * 
--from recipe r
--left join directions d
--on d.recipeid = r.recipeid
--left join RecipeIngredient ri
--on ri.RecipeId = r.RecipeId
--where r.recipeid = @RecipeId


