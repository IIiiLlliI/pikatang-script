# PikatangScript

基于 .NET 10 + WPF + WebView2 的网页游戏脚本工具

## 技术栈

- **.NET 10** - 运行时框架
- **WPF** - Windows Presentation Foundation UI 框架
- **WebView2** - Microsoft Edge WebView2 控件，用于内嵌浏览器

## 项目结构

```
PikatangScript/
├── Core/                      # 核心功能模块
│   └── BrowserCore.cs          # WebView2 核心封装
├── UI/                        # UI 层
│   ├── Views/                 # XAML 视图
│   │   └── MainWindow.xaml    # 主窗口
│   └── ViewModels/            # MVVM ViewModels
│       └── MainViewModel.cs    # 主窗口 ViewModel
├── Scripting/                 # 脚本引擎
│   ├── Engines/               # 脚本执行引擎
│   │   └── JavaScriptEngine.cs
│   └── Models/                # 脚本相关模型
│       └── ScriptContext.cs
├── Services/                  # 服务层
│   └── ScriptService.cs       # 脚本管理服务
├── Common/                    # 通用工具类
│   └── Logger.cs              # 日志工具
├── App.xaml                   # 应用程序入口
└── PikatangScript.csproj      # 项目文件
```

## 核心功能

- **内嵌浏览器** - 基于 WebView2 的游戏页面加载
- **脚本注入** - 向网页注入自定义 JavaScript 脚本
- **脚本管理** - 脚本的创建、编辑、执行和定时任务
- **DOM 操作** - 读取和修改网页元素
- **网络拦截** - 拦截和修改网络请求

### 构建运行

```bash
dotnet build
dotnet run
```

## 依赖包

- [Microsoft.Web.WebView2](https://developer.microsoft.com/zh-cn/microsoft-edge/webview2/) - 内嵌浏览器控件
