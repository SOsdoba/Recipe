using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAppSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookBookController : ControllerBase
    {

        [HttpGet]
        public List<bizCookbook> get()
        {
            return new bizCookbook().GetList(false, true);
        }

        [HttpGet("{cookbookid}")]
        public List<bizCookbook> get(int cookbookid)
        {
            return new bizCookbook().SearchWithId(cookbookid);
        }
    }
}
