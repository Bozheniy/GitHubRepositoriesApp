using GitHubRepositoriesApp.Application.Interfaces;
using GitHubRepositoriesApp.Domain.Entities;
using Newtonsoft.Json;


namespace GitHubRepositoriesApp.Infrastructure.Services
{
    public class RepositoryService : IRepositoryService
    {
        private string mainPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "files");
        private void CreateFolder()
        {
            try
            {
                if (!Directory.Exists(mainPath))
                {
                    Directory.CreateDirectory(mainPath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка создания папки: {ex}");
            }

        }
        public List<RepositoryModel> GetDataList()
        {
            try
            {
                var itemsList = new List<RepositoryModel>();
                string filePath = Path.Combine(mainPath, $"ReposList.json"); ;
                if (File.Exists(filePath))
                {
                    string text = File.ReadAllText(filePath);
                    itemsList = JsonConvert.DeserializeObject<List<RepositoryModel>>(text);
                }

                return itemsList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка получения: {ex}");
            }
        }

        public void SaveData(List<RepositoryModel> itemsList)
        {
            try
            {
                CreateFolder();
                string filePath = Path.Combine(mainPath, $"ReposList.json");
                string jsonData = JsonConvert.SerializeObject(itemsList);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка сохранения: {ex}");
            }
        }

        public bool FindFile()
        {
            try
            {
                string filePath = Path.Combine(mainPath, $"ReposList.json");
                return File.Exists(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка: {ex}");
            }
        }
    }
}
