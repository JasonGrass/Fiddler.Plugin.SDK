using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

// is required
[assembly: RequiredVersion("2.1.8.1")]

namespace Jgrass.FiddlerPlugin.Demo
{
    public class MyFiddlerFiddlerPlugin : FiddlerPluginApplication
    {
        public override void OnLoad()
        {
            FiddlerApplication.Log.LogString("Load MyFiddlerFiddlerPlugin");

            // base.OnLoad() is required
            base.OnLoad();
        }

        public override IFiddlerViewProvider GetFiddlerViewProvider()
        {
            return new MyFiddlerViewProvider();
        }

        public override void AutoTamperRequestAfter(Session oSession)
        {
            // do your work 
        }
    }
}
