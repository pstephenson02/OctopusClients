using System.ComponentModel;
using Octopus.Client.Extensibility;
using Octopus.Client.Extensibility.Attributes;

namespace Octopus.Client.Model
{
    [Description("Octopus can notify users when a new version is available. When it checks for new updates, it can include usage statistics to help us understand how the product is used and how we can improve it. [Learn more](https://g.octopushq.com/WhatIsIncludedInUsageStatistics).")]
    public class UpgradeConfigurationResource : IResource
    {
        [DisplayName("Notification mode")]
        [Description("Controls which notifications are shown in the portal when an update is available.")]
        [Writeable]
        public UpgradeNotificationMode NotificationMode { get; set; }
        
        [DisplayName("Check for updates")]
        [Description("Whether to check octopus.com to see if a new version is available.")]
        [Writeable]
        public bool AllowChecking { get; set; }

        [DisplayName("Include statistics")]
        [Description("Include usage statistics when checking for updates. See [our documentation](https://g.octopushq.com/WhatIsIncludedInUsageStatistics) for information about what is included.")]
        [Writeable]
        public bool IncludeStatistics { get; set; }

        public string Id { get; } = "upgrades";
        
        public LinkCollection Links { get; set; } = new LinkCollection();
    }
}