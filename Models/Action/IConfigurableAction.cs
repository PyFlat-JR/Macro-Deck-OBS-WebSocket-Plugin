namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    public interface IConfigurableAction
    {
        public ConfigBase GetConfig();
        public T GetConfig<T>()
            where T : ConfigBase;
    }
}
