using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginExample_PluginTemplate;

namespace PluginExample_Plugin
{
    public class MyPlugin : MyPluginTemplate
    {
        public MyPlugin(MyPluginTemplateBridge br)
        {
            this.Bridge = br;
        }

        public override void OnNumber(int n)
        {
            if (n % 15 == 0)
                this.Bridge.Write("FizzBuzz");
            else if (n % 5 == 0)
                this.Bridge.Write("Buzz");
            else if (n % 3 == 0)
                this.Bridge.Write("Fizz");
            else
                this.Bridge.Write(n.ToString());
        }
    }
}
