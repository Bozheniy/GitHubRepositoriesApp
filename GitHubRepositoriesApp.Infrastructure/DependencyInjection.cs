using GitHubRepositoriesApp.Application.Interfaces;
using GitHubRepositoriesApp.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GitHubRepositoriesApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IGitHubService, GitHubService>();
            services.AddScoped<IRepositoryService, RepositoryService>();

            return services;
        }
    }
}
