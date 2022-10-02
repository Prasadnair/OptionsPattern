using Microsoft.Extensions.Options;

namespace OptionsPattern.SnapShot.Implementation
{
    public class SnapShotCheckWithSingleton : ISnapShotCheckWithSingleton
    {
        private SnapShot _snapshot;
        public SnapShotCheckWithSingleton(IOptionsSnapshot<SnapShot> snapShot) =>
            (_snapshot) = (snapShot.Value);

        public Task<string> CheckSingletonService()
        {
            var interfaceName = this._snapshot.InterfaceName;
            return Task.FromResult(interfaceName);
        }
    }
}
