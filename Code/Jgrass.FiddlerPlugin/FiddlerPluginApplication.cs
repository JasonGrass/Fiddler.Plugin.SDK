using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

namespace Jgrass.FiddlerPlugin
{
    /// <summary>
    /// Fiddler 插件应用的入口
    /// </summary>
    public abstract class FiddlerPluginApplication : IAutoTamper3
    {
        public virtual void OnLoad()
        {
            var viewProvider = GetFiddlerViewProvider();
            if (viewProvider != null)
            {
                PluginViewController.InsertFiddlerTabPage(viewProvider);
            }
        }

        public abstract IFiddlerViewProvider GetFiddlerViewProvider();

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
