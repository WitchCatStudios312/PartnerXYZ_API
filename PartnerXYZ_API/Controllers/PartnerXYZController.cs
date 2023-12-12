using Microsoft.AspNetCore.Mvc;

namespace PartnerXYZ_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnerXYZController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            try
            {
                string? jsonString = Utilities.GetData();
                return jsonString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
