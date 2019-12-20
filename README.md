# Fiddler 插件 SDK 

快速地进行 Fiddler 插件开发，以及方便地接入 WPF/WinForm UserControl 作为 Fiddler 插件 Tab 的 UI 控件。

## Fiddler 插件开发

Fiddler 插件使用 .net 环境开发，默认 UI 的支持是 WinForm，可以通过在 WinForm 中嵌入 WPF 控件的方式使用 WPF 开发 UI。

## 如何使用

代码可参考项目中的 Demo.

* 1 继承 FiddlerPluginApplication，实现 GetFiddlerViewProvider 方法。

在 GetFiddlerViewProvider 方法中返回一个 IFiddlerViewProvider 的实例。

IFiddlerViewProvider 支持一次返回多个 FiddlerTabPage。

* 2 进行自定义的初始化工作

如果需要在 `OnLoad()` 方法中添加自定义初始化工作，仍需要调用 `base.OnLoad()`，否则插件UI将无法加载。

* 3 获取请求与响应数据

根据需要，override `MyFiddlerFiddlerPlugin` 中的方法，获取请求与响应数据。

`MyFiddlerFiddlerPlugin` 本质上继承的是 IAutoTamper3.

* 4 添加插件

将生成的 DLL 拷贝到 Fiddler 的插件目录，查看效果。

* 5 调试

将 VS 附加进程到 Fiddler 进程可以调试请求与响应数据的获取。

## 注意事项

你需要添加 `Fiddler.exe` 的引用，并且标记 `[assembly: RequiredVersion("2.1.8.1")]` 。
其中 2.1.8.1 是要求的最低 Fiddler 版本。

---

更多说明，可以参考博客：
[Fiddler 插件开发，使用 WPF 作为 UI 控件 - J.晒太阳的猫 - 博客园](https://www.cnblogs.com/jasongrass/p/12039575.html ) 

