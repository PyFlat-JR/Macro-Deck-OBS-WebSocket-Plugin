using SuchByte.OBSWebSocketPlugin.Enum;

namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public partial class GenericStateConfig : ConfigBase
    {
        public override int TargetVersion => 1;
        public StateMethodType Method;
    }
}
