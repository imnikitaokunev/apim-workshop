using Microsoft.AspNetCore.Mvc;

namespace BadAdvisor.Mvc.Controllers
{
    [Route("health")]
    public class HealthController: Controller
    {
        [HttpGet("live")]
        public async Task<IActionResult> Live()
        {
            return await Task.FromResult(Ok("Legacy Bad Advisor is healthy"));
        }
    }
}
