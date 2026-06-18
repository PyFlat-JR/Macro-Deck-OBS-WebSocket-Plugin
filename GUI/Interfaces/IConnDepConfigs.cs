using System.Collections.Generic;
using SuchByte.OBSWebSocketPlugin.Controllers;

namespace SuchByte.OBSWebSocketPlugin.GUI.Interfaces
{
    public interface IConnDepConfigs
    {
        virtual Connection Conn
        {
            get
            {
                var val = ConnectionSelector.Value ?? "";
                var list = PluginInstance.Main.Connections;
                return list.ContainsKey(val) ? list.GetValueOrDefault(val) : null;
            }
        }

        ConnectionSelector ConnectionSelector { get; }
    }
}
