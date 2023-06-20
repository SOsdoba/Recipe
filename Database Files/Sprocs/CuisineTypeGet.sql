use RecipeDB
go
create or alter procedure dbo.CuisineTypeGet(@cuisinetypeId int = 0, @All bit = 0, @CuisineType varchar(30) = '')
as 
begin
	select c.CuisineTypeId, c.CuisineType
	from CuisineType c
	where c.CuisineTypeId = @CuisineTypeId
	or @All = 1
	or (@cuisinetype  <> '' and c.CuisineType like '%' + @cuisinetype + '%')
end
go
/*
exec CuisineTypeGet
exec CuisineTypeGet @All = 1

exec CuisineTypeGet @cuisinetype = ''
exec CuisineTypeGet @cuisinetype = 'a'
exec CuisineTypeGet @cuisinetype = null

declare @cuisinetypeid int
select top 1 @cuisinetypeid = c.cuisinetypeid from cuisinetype c
exec CuisineTypeGet @cuisinetypeid = @cuisinetypeid
*/