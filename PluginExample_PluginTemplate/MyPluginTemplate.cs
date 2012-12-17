using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginArch;

namespace PluginExample_PluginTemplate
{
    public class MyPluginTemplate : PluginTemplate
    {
        public new MyPluginTemplateBridge Bridge
        {
            get
            {
                return (MyPluginTemplateBridge)base.Bridge;
            }
        }

        public virtual void OnNumber(int n)
        {
            // Nothing. Plugin doesn't implement this method.
        }
    }

    public abstract class MyPluginTemplateBridge : PluginTemplateBridge
    {
        public abstract void Write(string s);
    }
}
