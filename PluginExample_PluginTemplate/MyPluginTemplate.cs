using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginExample_PluginTemplate
{
    public class MyPluginTemplate
    {
        public MyPluginTemplateBridge Bridge;

        public virtual void OnNumber(int n)
        {
            // Nothing. Plugin doesn't implement this method.
        }
    }

    public abstract class MyPluginTemplateBridge
    {
        public abstract void Write(string s);
    }
}
