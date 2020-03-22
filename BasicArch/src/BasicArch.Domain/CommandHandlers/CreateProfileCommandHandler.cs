using System;
using System.Threading;
using System.Threading.Tasks;
using BasicArch.Domain.Commands;
using BasicArch.Domain.Interfaces;
using BasicArch.Domain.Models;
using MediatR;

namespace BasicArch.Domain.CommandHandlers
{
    public class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand, bool>
    {
        private readonly IProfileRepository _profileRepository;

        public CreateProfileCommandHandler(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public Task<bool> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
        {
            _profileRepository.CreateProfile(new Profile
            {
                AvatarUrl = request.AvatarUrl,
                Name = request.Name,
                Id = request.Id,
                CreateDate = DateTime.UtcNow.ToLocalTime()
            });

            return Task.FromResult(true);
        }
    }
}