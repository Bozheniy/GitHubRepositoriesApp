using GitHubRepositoriesApp.Domain.Entities;


namespace GitHubRepositoriesApp.Application.Interfaces
{
    public interface IRepositoryService
    {
        void SaveData(List<RepositoryModel> itemsList);
        List<RepositoryModel> GetDataList();
        bool FindFile();

    }
}
