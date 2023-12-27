create or alter procedure dbo.RecipeDelete(
	@RecipeId int
)
as 
begin
	begin try
		begin tran
			delete Directions where RecipeId = @recipeid
			delete RecipeIngredient where RecipeId = @recipeid
			delete Recipe where RecipeId = @recipeid
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end 
go


--begin
--	begin try 
--		begin tran
--			--delete Directions where RecipeId = @recipeid
			--delete RecipeIngredient where Recipeid = @recipeId
			--delete Recipe where RecipeId = @recipeid
--		commit
--	end try
--	begin catch
--		rollback;
--		throw
--	end catch
--end
--go
