
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebviewDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebPage : ContentPage
	{
		public WebPage (string url)
		{
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = url,
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            this.Content = new StackLayout
            {
                Children = { webView }
            };
        }
	}
}