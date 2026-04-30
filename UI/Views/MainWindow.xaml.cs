using System.Windows;
using Microsoft.Web.WebView2.Wpf;

namespace PikatangScript.UI.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeBrowser();
            Log("日志控制台已就绪");
        }

        private async void InitializeBrowser()
        {
            try
            {
                await Browser.EnsureCoreWebView2Async();
                Log("浏览器组件初始化完成");
            }
            catch (System.Exception ex)
            {
                Log($"浏览器初始化失败: {ex.Message}");
            }
        }

        public void Log(string message)
        {
            Dispatcher.Invoke(() =>
            {
                LogConsole.Text += $"[{DateTime.Now:HH:mm:ss}] {message}\n";
            });
        }

        public void Navigate(string url)
        {
            try
            {
                Browser.Source = new Uri(url);
            }
            catch (System.Exception ex)
            {
                Log($"导航失败: {ex.Message}");
            }
        }
    }
}