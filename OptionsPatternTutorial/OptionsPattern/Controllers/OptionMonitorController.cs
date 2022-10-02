using Microsoft.AspNetCore.Mvc;
using OptionsPattern.Monitor;

namespace OptionsPattern.Controllers
{
    public class OptionMonitorController : ControllerBase
    {
        private readonly IOptionsMonitorCheck _optionsMonitorCheck;
        public OptionMonitorController(IOptionsMonitorCheck monitorCheck)=>
            (_optionsMonitorCheck) = (monitorCheck);
        [HttpGet]
        [Route("optionsMonitor")]
        public IActionResult OptionsMonitor()
        {
            var interfaceName = this._optionsMonitorCheck.CheckOptionMonitor();

            return Ok(interfaceName);

        }
    }
}
