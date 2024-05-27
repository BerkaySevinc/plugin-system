using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPluginer;


namespace Plugin
{
    public class Plugin : IPlugin
    {

        public string Name { get; set; } = "Example Plugin";
        public string Description { get; set; } = "It's Plugins Description!";
        public string Author { get; set; } = "Beko-S";
        public string Version { get; set; } = "0.1";


        public void Load()
        {
            Console.WriteLine("Loaded");
        }

    }

}
