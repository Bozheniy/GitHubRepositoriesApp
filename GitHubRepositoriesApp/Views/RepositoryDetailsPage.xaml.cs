using GitHubRepositoriesApp.Domain.Entities;
using GitHubRepositoriesApp.ViewModels;

namespace GitHubRepositoriesApp.Views;

public partial class RepositoryDetailsPage : ContentPage
{
	public RepositoryDetailsPage(RepositoryModel repository)
	{
		InitializeComponent();
        BindingContext = new RepositoryDetailsPageViewModel(repository, this);
    }
}