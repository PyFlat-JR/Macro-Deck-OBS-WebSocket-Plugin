using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.Plugins;
using SuchByte.OBSWebSocketPlugin.Models.Action;

namespace SuchByte.OBSWebSocketPlugin.Actions
{
    public abstract class ActionBase : PluginAction, IConfigurableAction
    {
        public abstract ConfigBase GetConfig();

        public T GetConfig<T>()
            where T : ConfigBase
        {
            return JObject.Parse(this.Configuration ?? "{}").ToObject<T>();
        }
    }
}
