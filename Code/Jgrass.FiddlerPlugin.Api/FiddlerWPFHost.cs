using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jgrass.FiddlerPlugin
{
    internal partial class FiddlerWPFHost : UserControl, IFiddlerLayout
    {
        public FiddlerWPFHost()
        {
            InitializeComponent();
            this.SizeChanged += OnSizeChanged;
        }

        /// <summary>
        /// 添加 WPF 控件
        /// </summary>
        /// <param name="wpfUiElement"></param>
        public void AddWpfUIElement(System.Windows.UIElement wpfUiElement)
        {
            wpfElementHost.Child = wpfUiElement;
        }

        /// <summary>
        /// 在 Host 尺寸变化时，调整 WPF 控件的大小。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSizeChanged(object sender, EventArgs e)
        {
            wpfElementHost.Width = this.Width;
            wpfElementHost.Height = this.Height;
        }

        /// <summary>
        /// fiddler tab view 大小变化时，由 <see cref="IFiddlerLayout"/> 调用。
        /// </summary>
        /// <param name="size"></param>
        void IFiddlerLayout.OnTabViewSizeChanged(Size size)
        {
            // 更新此 Host 的尺寸。
            this.Width = size.Width;
            this.Height = size.Height;
        }

    }
}
