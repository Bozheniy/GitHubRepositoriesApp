
using GitHubRepositoriesApp.Domain.Entities;
using System.Collections.ObjectModel;

namespace GitHubRepositoriesApp.Helpers
{
    public static class CollectionFilter
    {
        public static ObservableCollection<RepositoryModel> FilterCollection(List<RepositoryModel> repositoryList, string searchText)
        {
            var filteredCollection = new ObservableCollection<RepositoryModel>();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                filteredCollection = new ObservableCollection<RepositoryModel>(repositoryList);
            }
            else
            {
                filteredCollection = new ObservableCollection<RepositoryModel>(repositoryList.Where(item => item.Name.Contains(searchText)));
            }
            return filteredCollection;
        }
    }
}
