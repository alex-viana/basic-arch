using BasicArch.Application.Interfaces;
using BasicArch.Application.Services;
using BasicArch.Domain.CommandHandlers;
using BasicArch.Domain.Commands;
using BasicArch.Domain.Core.Bus;
using BasicArch.Domain.Interfaces;
using BasicArch.Infra.Bus;
using BasicArch.Infra.Data.Context;
using BasicArch.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BasicArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain Handler
            services.AddScoped<IRequestHandler<CreateProfileCommand, bool>, CreateProfileCommandHandler>();

            // Applicatioon Layer
            services.AddScoped<IProfileService, ProfileService>();

            // Infra.Data Layer
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<BasicArchDbContext>();
        }
    }
}