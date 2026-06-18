using SuchByte.OBSWebSocketPlugin.Enum;

namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public partial class SetFilterStateConfig : ConfigBase
    {
        public override int TargetVersion => 1;

        public string SceneName;
        public string SourceName;
        public string FilterName;
        public VisibilityMethodType Method;
    }
}
