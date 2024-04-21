using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GitHubRepositoriesApp.Domain.Entities;


namespace GitHubRepositoriesApp.ViewModels
{
    public partial class RepositoryDetailsPageViewModel: ObservableObject
    {
        [ObservableProperty]
        private RepositoryModel currentRepository;
        private Page page;

        public RepositoryDetailsPageViewModel(RepositoryModel repository, Page page)
        {
            CurrentRepository = repository;
            this.page = page;
        }

        [RelayCommand]
        private async void OpenGitHubPage()
        {
            if(CurrentRepository.HtmlUrl != null) 
            {
                await Launcher.OpenAsync(CurrentRepository.HtmlUrl);
            }
            else
            {
                await page.DisplayAlert("Ошибка", "Ссылка на репозиторий не найдена", "Ok");
            }
            
        }


    }
}
