using Microsoft.AspNetCore.Mvc;
using OptionsPattern.SnapShot;

namespace OptionsPattern.Controllers
{
    public class SnapShotScopeController : ControllerBase
    {
        private ISnapShotCheckWithScope _scope;
        public SnapShotScopeController(ISnapShotCheckWithScope scope) =>
            (_scope) = (scope);

        [HttpGet]
        [Route("testSnapshotScope")]
        public IActionResult GetSnapShot()
        {
            var interfaceName = this._scope.CheckScopedService();

            return Ok(interfaceName);

        }
    }
}
