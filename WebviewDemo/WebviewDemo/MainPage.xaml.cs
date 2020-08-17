using System.Windows.Input;
using Xamarin.Forms;

namespace WebviewDemo
{
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateCommand { private set; get; }
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigateCommand = new Command<string>(async (string url) =>
            {
                await Navigation.PushAsync(new WebPage(url));
            });

            BindingContext = this;
        }
    }
}
