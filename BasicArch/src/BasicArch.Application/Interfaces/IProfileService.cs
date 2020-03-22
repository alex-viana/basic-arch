using System;
using BasicArch.Application.ViewModels;
using BasicArch.Domain.Commands;

namespace BasicArch.Application.Interfaces
{
    public interface IProfileService
    {
        void CreateProfile(CreateProfileCommand command);
        ProfileViewModel GetProfile(Guid id);
    }
}