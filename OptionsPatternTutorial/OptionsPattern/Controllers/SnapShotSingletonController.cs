using Microsoft.AspNetCore.Mvc;
using OptionsPattern.SnapShot;

namespace OptionsPattern.Controllers
{
    public class SnapShotSingletonController : ControllerBase
    {
        private ISnapShotCheckWithSingleton _scope;
        public SnapShotSingletonController(ISnapShotCheckWithSingleton scope) =>
            (_scope) = (scope);

        [HttpGet]
        [Route("testSnapshotSingleton")]
        public IActionResult GetSnapShot()
        {
            var interfaceName = this._scope.CheckSingletonService();

            return Ok(interfaceName);

        }
    }
}
