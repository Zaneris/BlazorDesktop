using System.Net.Http;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            serviceCollection.AddScoped(sp => new HttpClient());
            var blazor = new BlazorWebView()
            {
                Dock = DockStyle.Fill,
                HostPage = "../Shared/wwwroot/webview.html",
                Services = serviceCollection.BuildServiceProvider(),
            };
            blazor.RootComponents.Add<Shared.App>("#app");
            Controls.Add(blazor);
        }

    }
}
