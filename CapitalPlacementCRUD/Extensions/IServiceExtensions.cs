using AutoMapper;
using CapitalPlacementCRUD.Domain.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementCRUD.Extensions
{
    public static class IServiceExtensions
    {
        public static void ConfigureMapping( this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
            var mapperConfig = new MapperConfiguration(map =>
            {
                map.AddProfile<AutomapperProfiles>();
            });
            services.AddSingleton(mapperConfig.CreateMapper()); 
        }
    }
}
