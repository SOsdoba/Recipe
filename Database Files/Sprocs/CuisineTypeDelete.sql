create or alter procedure dbo.CuisineTypeDelete(
	@CuisineTypeId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	delete CuisineType where CuisineTypeId = @CuisineTypeId
		
	return @return
end 
go
/*
select *
from cuisinetype
----.\SQLExpress
use RecipeDB
go
exec CuisineTypeDelete
@CuisineTypeId = 4,
@Message = null

