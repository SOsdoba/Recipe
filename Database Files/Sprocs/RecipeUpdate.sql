create or alter proc dbo.RecipeUpdate(
	@Recipeid int output,
	@UsersId int, 
	@CuisineTypeId int,
	@RecipeName varchar (40),
	@Calories int,
	@RecipeStatus varchar(40) output,
	@DraftDate datetime output,
	@PublishDate datetime,
	@ArchiveDate datetime,
	@Message varchar (500) = '' output
)
as 
begin
	declare @return int = 0

	select @recipeid = isnull(@recipeid, 0), @draftdate = isnull(@draftdate, getdate())

	if @recipeid = 0
	begin
		select @DraftDate = getdate()
		insert Recipe(UsersId, CuisineTypeId,RecipeName, Calories, DraftDate, PublishDate, ArchiveDate)
		values(@UsersId, @CuisineTypeId, @RecipeName, @Calories, @DraftDate, @PublishDate, @ArchiveDate)
		
		select @recipeid = SCOPE_IDENTITY()
		select @RecipeStatus = r.recipestatus from Recipe r where r.recipeid = @Recipeid
	end
	else
	begin 
		update Recipe
		set
		UsersId = @UsersId,
		CuisineTypeId = @CuisineTypeId,
		RecipeName = @RecipeName,
		Calories = @Calories,
		DraftDate = @DraftDate,
		PublishDate = @PublishDate,
		ArchiveDate = @ArchiveDate
		where RecipeId = @RecipeId
	end

	return @return
end 
go




