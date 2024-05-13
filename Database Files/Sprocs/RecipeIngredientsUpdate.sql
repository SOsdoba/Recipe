create or alter procedure dbo.RecipeIngredientsUpdate(
	@RecipeIngredientId int output,
	@RecipeId int,
	@IngredientId int,
	@MeasurementTypeId int,
	@Amount decimal,
	@IngredientSequence int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

	if @RecipeIngredientId = 0
	begin 
		insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, SequenceOfIngredients)
		values(@RecipeId, @IngredientId, @MeasurementTypeId, @Amount, @IngredientSequence)

		select @RecipeIngredientId = scope_identity()
	end
	else
	begin
		update RecipeIngredient
		set
			RecipeId = @RecipeId,
			IngredientId = @IngredientId,
			MeasurementTypeId = @MeasurementTypeId,
			Amount = @Amount,
			SequenceOfIngredients = @IngredientSequence
		where RecipeIngredientId = @RecipeIngredientId
	end

	return @return
end
go