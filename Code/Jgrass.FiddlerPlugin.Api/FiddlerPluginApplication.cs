using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

// Fiddler 最低版本要求
[assembly: RequiredVersion("2.1.8.1")]

namespace Jgrass.FiddlerPlugin
{
    /// <summary>
    /// Fiddler 插件应用的入口
    /// </summary>
    public class FiddlerPluginApplication
    {
        public virtual void OnLoad()
        {
            System.Windows.MessageBox.Show("Jgrass.FiddlerPlugin OnLoad");

            var viewProvider = GetFiddlerViewProvider();
            if (viewProvider != null)
            {
                PluginViewController.InsertFiddlerTabPage(viewProvider);
            }
        }

        public virtual IFiddlerViewProvider GetFiddlerViewProvider()
        {
            return null;
        }

        public virtual void OnBeforeUnload()
        {

        }

        public virtual void AutoTamperRequestBefore(Session oSession)
        {

        }

        public virtual void AutoTamperRequestAfter(Session oSession)
        {

        }

        public virtual void AutoTamperResponseBefore(Session oSession)
        {

        }

        public virtual void AutoTamperResponseAfter(Session oSession)
        {

        }

        public virtual void OnBeforeReturningError(Session oSession)
        {

        }

        public virtual void OnPeekAtResponseHeaders(Session oSession)
        {

        }

        public virtual void OnPeekAtRequestHeaders(Session oSession)
        {

        }
    }
}
