using SuchByte.OBSWebSocketPlugin.Enum;

namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public partial class ToggleConnectionConfig : ConfigBase
    {
        public override int TargetVersion => 1;

        public SelectionType SelectionType;
    }
}
