using Microsoft.AspNetCore.Mvc;

namespace _2.ChapterTwo2._9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public string GetName()
        {
            return "Customer name";
        }
    }
}
