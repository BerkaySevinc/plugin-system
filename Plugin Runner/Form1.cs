using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPluginer;


namespace Plugin_Runner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnLoadPlugin_Click(object sender, EventArgs e)
        {
            string pluginFilePath = SelectPluginFile();
            if (pluginFilePath is null) return;
            // Get Plugin File Path

            IPlugin[] plugins = GetPlugins<IPlugin>(pluginFilePath);

            if (plugins.Length == 0)
            {
                MessageBox.Show("Plugins Not Found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get Plugins

            foreach (IPlugin plugin in plugins)
            {
                dgvPlugins.Rows.Add(plugin.Name, plugin.Version);
                logs.Items.Add("   - " + plugin.Name + " Loaded...");
                logs.Items.Add("   Author: " + plugin.Author + ", Version: " + plugin.Version);
                plugin.Load();
            }
            // Load Plugins
        }


        #region Select Plugin File

        public static string SelectPluginFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Plugin File (*.dll)|*.dll";

            if (ofd.ShowDialog() != DialogResult.OK) return null;

            return ofd.FileName;
        }

        #endregion

        #region Get Plugins

        public static TInterface[] GetPlugins<TInterface>(string dllPath) where TInterface : class
        {
            Type interfaceType = typeof(TInterface);
            if (!interfaceType.IsInterface) return new TInterface[0];

            Assembly.LoadFile(Path.GetFullPath(dllPath));

            Type[] types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
                .ToArray();

            List<TInterface> plugins = new List<TInterface>();
            foreach (Type type in types)
                plugins.Add((TInterface)Activator.CreateInstance(type));

            return plugins.ToArray();
        }

        #endregion

    }
}
