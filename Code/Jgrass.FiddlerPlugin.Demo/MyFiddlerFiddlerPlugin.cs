using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

namespace Jgrass.FiddlerPlugin.Demo
{
    public class MyFiddlerFiddlerPlugin : IAutoTamper3
    {
        public void OnLoad()
        {
            System.Windows.MessageBox.Show("Jgrass.FiddlerPlugin.Demo OnLoad");
        }

        public void OnBeforeUnload()
        {
        }

        public IFiddlerViewProvider GetFiddlerViewProvider()
        {
            return null;
            // return new MyFiddlerViewProvider();
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
        }

        public void AutoTamperRequestAfter(Session oSession)
        {
            // if you want to use other fiddler api, should add reference of "Fiddler.exe" for this project.
            FiddlerApplication.Log.LogString("Build MyFiddlerViewProvider");
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
        }

        public void OnBeforeReturningError(Session oSession)
        {
        }

        public void OnPeekAtResponseHeaders(Session oSession)
        {
        }

        public void OnPeekAtRequestHeaders(Session oSession)
        {
        }
    }
}
