using SuchByte.OBSWebSocketPlugin.Enum;

namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public partial class SetSourceVolumeConfig : ConfigBase
    {
        public override int TargetVersion => 1;

        public string SourceName;
        public IncrementalMethodType Method;
        public int Decibel;
    }
}
