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
            return new bizRecipe().GetList(false, true); ;
            
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
        //[FromForm]
        [HttpPost]
        public IActionResult PostRecipe(bizRecipe recipe)
        {
            try
            {
                recipe.Save();
                return Ok(recipe);
            }
            catch(Exception ex)
            {
                recipe.ErrorMessage = ex.Message;
                return BadRequest(recipe);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int recipeid)
        {
            bizRecipe r = new();
            try
            { 
                r.Delete(recipeid);
                return Ok(r);
            }
            catch(Exception ex)
            {
                r.ErrorMessage = ex.Message;
                return BadRequest(r);
            }
        }
    }
}
