using RecipeAppSystem;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> get()
        {
            return new bizRecipe().GetList(false, true);
        }

        [HttpGet("{recipeid}")]
        public List<bizRecipe> get(int recipeid)
        {
            return new bizRecipe().SearchWithId(recipeid);
        }

        [HttpGet("getbycookbook/{cookbookname}")]
        public List<bizRecipe> GetByCookbook(string cookbookname)
        {
            try
            {
                return new bizRecipe().SearchByCookBook(cookbookname);
            }
            catch (Exception ex)
            {
                // Log the exception here
                throw new Exception("An error occurred while processing your request. Please try again later.", ex);
            }
        }

        [HttpGet("getbycuisine/{cuisinetypeid}")]
        public List<bizRecipe> GetByCuisine(int cuisinetypeid)
        {
            try
            {
                return new bizRecipe().SearchByCuisineTypeId(cuisinetypeid);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while processing your request. Please try again later.", ex);
            }
        }

        [HttpPost]
        public IActionResult PostRecipe([FromForm]RecipeCreate recipe)
        {
            try
            {
                recipe.Save();
                return Ok(new {message = "Recipe Saved!", recipeid = recipe.RecipeId});
            }
            catch(Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult Delete(int recipeid)
        {
            try
            { 
                bizRecipe r = new();
                r.Delete(recipeid);
                return Ok(new {message = "Recipe Deleted!"});
            }
            catch(Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }
    }
}
