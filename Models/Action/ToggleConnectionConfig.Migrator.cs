using System.Linq;

namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public partial class ToggleConnectionConfig
    {
        protected override void Upgrade(int prevVersion)
        {
            if (prevVersion == 0)
                V1();
        }

        private void V1()
        {
            Version = 1;
            SelectionType = Enum.SelectionType.All;
            ConnectionName = PluginInstance.Main.Connections.FirstOrDefault().Key;
        }
    }
}
