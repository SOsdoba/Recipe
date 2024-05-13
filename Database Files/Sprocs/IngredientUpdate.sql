create or alter proc dbo.IngredientUpdate(
	@Ingredientid int output,
	@IngredientName varchar(40),
	@Message varchar (500) = '' output
)
as 
begin
	declare @return int = 0

	select @Ingredientid = isnull(@Ingredientid, 0)

	if @Ingredientid = 0
	begin
		select @Ingredientid= SCOPE_IDENTITY()
		insert Ingredient(IngredientName)
		values(@IngredientName)
	end
	else
	begin 
		update Ingredient
		set
		IngredientName = @IngredientName
		where Ingredientid = @Ingredientid
	end

	return @return
end 
go
