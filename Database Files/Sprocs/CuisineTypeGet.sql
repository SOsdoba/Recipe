use RecipeDB
go
create or alter procedure dbo.CuisineTypeGet(@CuisineTypeId int = 0, @CuisineType varchar(30) = '', @All bit = 0, @IncludeBlank bit = 0)
as 
begin
	select c.CuisineTypeId, c.CuisineType
	from CuisineType c
	where c.CuisineTypeId = @CuisineTypeId
	or (@CuisineType  <> '' and c.CuisineType like '%' + @CuisineType + '%')
	or @All = 1
	union select 0, '' where @IncludeBlank = 1
	order by c.cuisineType
end
go
/*
exec CuisineTypeGet
exec CuisineTypeGet @All = 1 ,@IncludeBlank = 1

exec CuisineTypeGet @CuisineType = ''
exec CuisineTypeGet @CuisineType = 'a'
exec CuisineTypeGet @CuisineType = null

declare @CuisineTypeId int
select top 1 @CuisineTypeId = c.CuisineTypeId from CuisineType c
exec CuisineTypeGet @CuisineTypeId = @CuisineTypeId
*/