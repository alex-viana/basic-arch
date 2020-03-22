using System;
using AutoMapper;
using BasicArch.Application.Interfaces;
using BasicArch.Application.ViewModels;
using BasicArch.Domain.Commands;
using BasicArch.Domain.Core.Bus;
using BasicArch.Domain.Interfaces;

namespace BasicArch.Application.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public ProfileService(IProfileRepository profileRepository, IMediatorHandler bus, IMapper mapper)
        {
            _profileRepository = profileRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public void CreateProfile(CreateProfileCommand command)
        {
            _bus.SendCommand(command);
        }

        public ProfileViewModel GetProfile(Guid id)
        {
            return _mapper.Map<ProfileViewModel>(_profileRepository.GetProfile(id));
        }
    }
}