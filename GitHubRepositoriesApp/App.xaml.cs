using GitHubRepositoriesApp.Views;

namespace GitHubRepositoriesApp
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
