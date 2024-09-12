using Microsoft.AspNetCore.Mvc;
using SignalR.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        // GET: api/<OfferController>
        [HttpGet]
        public double Get()
        {
            return FileHelper.Read();
        }
        [HttpGet("Increase")]
        public void Increase(double data)
        {
            var result = FileHelper.Read()+data;
            FileHelper.Write(result);
        }
        
    }
}
