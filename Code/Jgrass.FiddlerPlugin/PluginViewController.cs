using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

namespace Jgrass.FiddlerPlugin
{
    internal class PluginViewController
    {
        private static readonly IList<IFiddlerLayout> FiddlerLayoutViews = new List<IFiddlerLayout>();

        public static void InsertFiddlerTabPage(IFiddlerViewProvider fiddlerViewProvider)
        {
            // 提供 fiddler 窗口变化的支持
            FiddlerApplication.UI.tabsViews.SizeChanged += TabsViewsOnSizeChanged;
            foreach (var fiddlerTabPage in fiddlerViewProvider.BuildFiddlerTabPages())
            {
                InsertFiddlerTabPage(fiddlerTabPage);
            }
        }

        private static void InsertFiddlerTabPage(FiddlerTabPage fiddlerTabPage)
        {
            // new tab
            var tabPage = new System.Windows.Forms.TabPage(fiddlerTabPage.TabTitle) { ImageIndex = (int)fiddlerTabPage.TabIcon };

            if (fiddlerTabPage.WPFUserControl != null)
            {
                InsertWPFTabPage(tabPage, fiddlerTabPage.WPFUserControl, fiddlerTabPage.WPFHostSetter);
            }
            else if (fiddlerTabPage.WinFormUserControl != null)
            {
                InsertWinFormTabPage(tabPage, fiddlerTabPage.WinFormUserControl);
            }

            UpdateViewSize();
        }

        private static void InsertWinFormTabPage(
            System.Windows.Forms.TabPage tabPage, 
            System.Windows.Forms.UserControl userControl)
        {
            // add view to tab 
            tabPage.Controls.Add(userControl);
            // add tab to fiddler 
            FiddlerApplication.UI.tabsViews.TabPages.Add(tabPage);

            if (userControl is IFiddlerLayout layout)
            {
                FiddlerLayoutViews.Add(layout);
            }
        }

        private static void InsertWPFTabPage(
            System.Windows.Forms.TabPage tabPage, 
            System.Windows.Controls.UserControl userControl,
            Action<System.Windows.Forms.UserControl>? setter)
        {
            // new WinForm Host
            var host = new FiddlerWPFHost();

            // 默认样式
            host.BackColor = Color.White;
            host.Padding = System.Windows.Forms.Padding.Empty;
            host.Margin = System.Windows.Forms.Padding.Empty;

            setter?.Invoke(host);

            // add view to host
            host.AddWpfUIElement(userControl);
            // add host to tab 
            tabPage.Controls.Add(host);
            // add tab to fiddler 
            FiddlerApplication.UI.tabsViews.TabPages.Add(tabPage);

            FiddlerLayoutViews.Add(host);
        }

        private static void TabsViewsOnSizeChanged(object sender, EventArgs e)
        {
            UpdateViewSize();
        }

        private static void UpdateViewSize()
        {
            var size = FiddlerApplication.UI.tabsViews.Size;
            foreach (var view in FiddlerLayoutViews)
            {
                view.OnTabViewSizeChanged(size);
            }
        }
    }
}
