using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public abstract class ConfigBase
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public int Version { get; internal set; } = 0;

        public abstract int TargetVersion { get; }
        public string ConnectionName;

        [JsonExtensionData]
        protected Dictionary<string, object> ExtraAttributes { get; set; }

        [JsonIgnore]
        protected bool NeedsUpgrade => Version != TargetVersion;

        public ConfigBase UpgradeConfig()
        {
            var prevVersion = Version;
            while (Version != TargetVersion)
            {
                switch (Version)
                {
                    case 0:
                        Upgrade(Version);
                        break;
                }

                if (prevVersion == Version)
                    throw new ObsConfigUpgradeException(
                        String.Format("Upgrade failed to upgrade from {0}", prevVersion)
                    );
            }
            return this;
        }

        protected abstract void Upgrade(int version);
    }
}
