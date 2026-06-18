using SuchByte.OBSWebSocketPlugin.Enum;

namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public partial class SetAudioMutedConfig : ConfigBase
    {
        public override int TargetVersion => 1;

        public string SourceName;
        public AudioMethodType Method;
    }
}
