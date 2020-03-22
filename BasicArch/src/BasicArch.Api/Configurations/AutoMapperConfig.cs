using AutoMapper;
using BasicArch.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace BasicArch.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BasicArch.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
