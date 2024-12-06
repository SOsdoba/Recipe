using RecipeAppSystem;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public List<bizUsers> get()
        {
            return new bizUsers().GetList(false, true);
        }

    }
}
