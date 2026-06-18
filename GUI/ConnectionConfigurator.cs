using System.Windows.Forms;
using SuchByte.OBSWebSocketPlugin.Language;
using SuchByte.OBSWebSocketPlugin.Models;

namespace SuchByte.OBSWebSocketPlugin.GUI
{
    public partial class ConnectionConfigurator : UserControl
    {
        public ConnectionConfigurator()
        {
            InitializeComponent();

            lblName.Text = PluginLanguageManager.PluginStrings.Name;
            lblHost.Text = PluginLanguageManager.PluginStrings.Host;
            lblPassword.Text = PluginLanguageManager.PluginStrings.Password;
        }

        public ConnectionConfig Value
        {
            get
            {
                return new ConnectionConfig
                {
                    name = name.Text,
                    host = host.Text,
                    password = password.Text,
                };
            }
        }
    }
}
