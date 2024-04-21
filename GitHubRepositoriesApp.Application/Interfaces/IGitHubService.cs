using GitHubRepositoriesApp.Domain.Entities;


namespace GitHubRepositoriesApp.Application.Interfaces
{
    public interface IGitHubService
    {
        Task<List<RepositoryModel>> GetCSharpRepositoriesAsync();
    }
}
