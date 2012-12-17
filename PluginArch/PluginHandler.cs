using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace PluginArch
{
    public class PluginHandler<T> where T : new()
    {
        List<object> plugins;
        object bridge;

        public PluginHandler(object br)
        {
            this.plugins = new List<object>();
            this.bridge = br;
        }

        public void AddPlugin(Assembly asmbl)
        {
            foreach (Type t in asmbl.GetTypes())
            {
                if (t.BaseType == typeof(T))
                    plugins.Add(Activator.CreateInstance(t, this.bridge));
            }
        }

        public void Invoke(string d, params object[] args)
        {
            //if (typeof(T).GetMethod(d, BindingFlags.Public) == null)
            //    throw new ArgumentException("Delegate is not a method of plugin type.");

            foreach (object p in this.plugins)
            {
                p.GetType().GetMethod(d).Invoke(p, args);
            }
        }
    }
}
