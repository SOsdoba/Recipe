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
    }
}
