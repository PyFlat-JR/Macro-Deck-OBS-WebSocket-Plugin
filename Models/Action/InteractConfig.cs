namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public partial class InteractConfig : ConfigBase
    {
        public override int TargetVersion => 1;

        public string SceneName;
        public string SourceName;
    }
}
