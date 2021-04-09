using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using Shared.Layout;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
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
