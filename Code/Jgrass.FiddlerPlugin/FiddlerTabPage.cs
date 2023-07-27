using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

namespace Jgrass.FiddlerPlugin
{
    public class FiddlerTabPage
    {
        /// <summary>
        /// 获取 Fiddler Tab 标签页的 Title。
        /// </summary>
        public string TabTitle { get; }

        /// <summary>
        /// 获取或设置 Fiddler Tab 标签页的 Icon。
        /// </summary>
        public SessionIcons TabIcon { get; set; } = SessionIcons.Silverlight;

        /// <summary>
        /// 获取 Fiddler Tab 标签页内的 UserControl。
        /// </summary>
        public System.Windows.Forms.UserControl? WinFormUserControl { get; }

        /// <summary>
        /// 获取 Fiddler Tab 标签页内的 UserControl。
        /// </summary>
        public System.Windows.Controls.UserControl? WPFUserControl { get; }

        /// <summary>
        /// 对 WPF 容器进行自定义的设置。通常是样式的重置。
        /// 仅在使用 WPF 类型的控件时有效。
        /// </summary>
        public Action<System.Windows.Forms.UserControl>? WPFHostSetter { get; set; }

        public FiddlerTabPage(string tabTitle, System.Windows.Forms.UserControl winFormUserControl)
        {
            if (string.IsNullOrWhiteSpace(tabTitle))
            {
                throw new ArgumentNullException(nameof(tabTitle));
            }

            TabTitle = tabTitle;
            WinFormUserControl = winFormUserControl ?? throw new ArgumentNullException(nameof(winFormUserControl));
        }

        public FiddlerTabPage(string tabTitle, System.Windows.Controls.UserControl wpfUserControl)
        {
            if (string.IsNullOrWhiteSpace(tabTitle))
            {
                throw new ArgumentNullException(nameof(tabTitle));
            }

            TabTitle = tabTitle;
            WPFUserControl = wpfUserControl ?? throw new ArgumentNullException(nameof(wpfUserControl));
        }

    }
}
