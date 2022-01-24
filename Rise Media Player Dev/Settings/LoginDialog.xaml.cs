using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Rise.App.Settings
{
    public sealed partial class LoginDialog : ContentDialog
    {
        public LoginDialog()
        {
            this.InitializeComponent();
            Loaded += LoginDialog_Loaded;
        }

        private void LoginDialog_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            App app = Application.Current  as App;
            webview.Navigate(app.urilink);
        }
    }
}