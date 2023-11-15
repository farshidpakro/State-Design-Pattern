using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using State_Design_Pattern.State;

namespace State_Design_Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StateController : ControllerBase
    {
        [HttpPost("StateMachinTest")]
    public async Task<IActionResult>  StateMachinTest(int currentStatus)
    {
        var machin = new CarStatusMachin();
        machin.GoToNextStatus(currentStatus);
        return Ok("با موفقیت انجام شد");
    }
    }
}