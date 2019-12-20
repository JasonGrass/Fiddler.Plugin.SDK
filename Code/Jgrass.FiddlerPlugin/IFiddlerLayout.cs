using System.Drawing;

namespace Jgrass.FiddlerPlugin
{
    /// <summary>
    /// 为插件提供 fiddler 布局相关的支持
    /// </summary>
    internal interface IFiddlerLayout
    {
        /// <summary>
        /// fiddler tab view 尺寸变化时调用。
        /// </summary>
        /// <param name="size"></param>
        void OnTabViewSizeChanged(Size size);
    }
}