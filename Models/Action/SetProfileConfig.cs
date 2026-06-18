namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public partial class SetProfileConfig : ConfigBase
    {
        public override int TargetVersion => 1;

        public string Profile;
    }
}
