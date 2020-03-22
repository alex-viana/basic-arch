using AutoMapper;
using BasicArch.Application.ViewModels;

namespace BasicArch.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<BasicArch.Domain.Models.Profile, ProfileViewModel>();
        }
    }
}