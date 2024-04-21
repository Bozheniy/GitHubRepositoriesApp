using GitHubRepositoriesApp.Application.Interfaces;
using GitHubRepositoriesApp.Domain.Entities;
using System.Text.Json;

namespace GitHubRepositoriesApp.Infrastructure.Services
{
    public class GitHubService: IGitHubService
    {
        private readonly string GithubApiUrl = "https://api.github.com/users/Bozheniy/repos";

        public async Task<List<RepositoryModel>> GetCSharpRepositoriesAsync()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(GithubApiUrl);

                    response.EnsureSuccessStatusCode();

                    var result = new List<RepositoryModel>();
                    result = await JsonSerializer.DeserializeAsync<List<RepositoryModel>>(await response.Content.ReadAsStreamAsync());

                    return result;
                }
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException($"Ошибка HTTP-запроса: {ex.Message}");
            }
            catch (JsonException ex)
            {
                throw new Exception($"Ошибка десериализации JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Непредвиденная ошибка: {ex.Message}");
            }


        }
    }
}
