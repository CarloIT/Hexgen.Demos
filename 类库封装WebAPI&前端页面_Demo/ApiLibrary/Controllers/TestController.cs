using Microsoft.AspNetCore.Mvc;

namespace ApiLibrary.Controllers
{
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Message = $"来自嵌入式API的数据，ControllerName={nameof(TestController)}",
                Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
            });
        }
    }
}