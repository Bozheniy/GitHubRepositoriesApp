using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GitHubRepositoriesApp.Application.Interfaces;
using GitHubRepositoriesApp.Domain.Entities;
using GitHubRepositoriesApp.Helpers;
using GitHubRepositoriesApp.Views;
using System.Collections.ObjectModel;

namespace GitHubRepositoriesApp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<RepositoryModel> repositoryCollection;
        [ObservableProperty]
        private string searchItem;

        private List<RepositoryModel> repositoryList;
        private IGitHubService gitHubService;
        private IRepositoryService repository;
        private Page _page;

        public MainPageViewModel(Page page, IGitHubService gitHubService, IRepositoryService repository)
        {
            _page = page;
            this.gitHubService = gitHubService;
            this.repository = repository;
            GetData();
        }
        private async Task GetData()
        {
            if (repository.FindFile())
            {
                await GetFromLocalStorage();
            }
            else
            {
                await GetFromGitHubApiAndSave();
            }
        }

        private async Task GetFromGitHubApiAndSave()
        {
            try
            {
                List<RepositoryModel> repositoryList = await gitHubService.GetCSharpRepositoriesAsync();

                if (repositoryList != null && repositoryList.Any())
                {
                    RepositoryCollection = new ObservableCollection<RepositoryModel>(repositoryList);
                    repository.SaveData(repositoryList);
                }
            }
            catch (Exception ex)
            {
                DisplayAlert(ex);
            }
        }

        private async Task GetFromLocalStorage()
        {
            try
            {
                List<RepositoryModel> repositoryList = repository.GetDataList();

                if (repositoryList != null && repositoryList.Any())
                {
                    RepositoryCollection = new ObservableCollection<RepositoryModel>(repositoryList);
                }
            }
            catch (Exception ex)
            {
                DisplayAlert(ex);
            }
        }

        private void DisplayAlert(Exception ex)
        {
            _page.DisplayAlert("Ошибка", ex.Message, "Ok");
        }

        [RelayCommand]
        private void SearchTextChanged()
        {
            RepositoryCollection = CollectionFilter.FilterCollection(repositoryList, SearchItem);
        }

        [RelayCommand]
        private async void ItemSelected(RepositoryModel item)
        {
            if (item != null) 
            { 
                await App.Current.MainPage.Navigation.PushAsync(new RepositoryDetailsPage(item)); 
            }
        }

    }
}
