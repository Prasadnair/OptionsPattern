using Microsoft.Extensions.Options;

namespace OptionsPattern.Monitor.Implementation
{
    public class OptionMonitorCheck : IOptionsMonitorCheck
    {
        private readonly MonitorOption _monitorOption;
        public OptionMonitorCheck(IOptionsMonitor<MonitorOption> optionsMonitor) =>
            (_monitorOption) = (optionsMonitor.CurrentValue);

        public Task<string> CheckOptionMonitor()
        {
            var interfaceName = this._monitorOption.InterfaceName;
            return Task.FromResult(interfaceName);
        }
    }
}
