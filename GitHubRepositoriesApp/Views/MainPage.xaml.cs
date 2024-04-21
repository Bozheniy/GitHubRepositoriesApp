using GitHubRepositoriesApp.Infrastructure.Services;
using GitHubRepositoriesApp.ViewModels;

namespace GitHubRepositoriesApp.Views
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(this, new GitHubService(), new RepositoryService());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            collectionView.SelectedItem = null;
        }
    }

}
