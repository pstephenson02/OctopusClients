using System.ComponentModel;

namespace Octopus.Client.Model
{
    public enum UpgradeNotificationMode
    {
        [Description("Always show")]
        AlwaysShow,
        [Description("Show only major & minor upgrades (not patches)")]
        ShowOnlyMajorMinor,
        [Description("Never show")]
        NeverShow
    }
}
