using Microsoft.Extensions.Options;

namespace OptionsPattern.SnapShot.Implementation
{
    public class SnapShotCheckWithScope : ISnapShotCheckWithScope
    {
        private SnapShot _snapshot;
        public SnapShotCheckWithScope(IOptionsSnapshot<SnapShot> snapShot) =>
            (_snapshot) = (snapShot.Value); 
        

        public Task<string> CheckScopedService()
        {
            var interfaceName = this._snapshot.InterfaceName;
            return Task.FromResult(interfaceName);
        }
    }
}
