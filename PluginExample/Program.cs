using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginArch;
using PluginExample_PluginTemplate;
using System.Reflection;
using System.IO;

namespace PluginExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PluginHandler<MyPluginTemplate> handler = new PluginHandler<MyPluginTemplate>(new MyPluginBridge());

            string path = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), 
                @"..\..\..\PluginExample_Plugin\bin\Debug\PluginExample_Plugin.dll");
            
            handler.AddPlugin(Assembly.LoadFile(path));

            for (int i = 0; i <= 100; i++)
                handler.Invoke("OnNumber", i);

            Console.ReadKey();
        }
    }

    class MyPluginBridge : MyPluginTemplateBridge
    {
        public override void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}
