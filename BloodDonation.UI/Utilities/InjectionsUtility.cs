
using BloodDonation.Infrastructure.IRepository;
using BloodDonation.Infrastructure.Repository;
using BloodDonation.Service.IService;
using BloodDonation.Service.Service;

namespace BloodDonation.UI.Utilities;
public static class InjectionsUtility
{
    public static IServiceCollection AddInjectUtility(this IServiceCollection services)
    {

        #region Repositories
        services.AddTransient<IBloodRequestRepository, BloodRequestRepository>();
        services.AddTransient<IBloodRequestDonorRepository, BloodRequestDonorRepository>();
        services.AddTransient<IHealthHistorySurveyRepository, HealthHistorySurveyRepository>();
        services.AddTransient<IUserRepostiroy, UserRepostiroy>();
        #endregion

        #region Services
        services.AddScoped<IBloodRequestService, BloodRequestService>();
        services.AddScoped<IBloodRequestDonorService, BloodRequestDonorService>();
        services.AddScoped<IHealthHistorySurveyService, HealthHistorySurveyService>();
        services.AddScoped<IUserService, UserService>();
        #endregion

        return services;
    }
}