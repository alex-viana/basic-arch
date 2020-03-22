using System;
using System.Linq;
using BasicArch.Domain.Models;

namespace BasicArch.Domain.Interfaces
{
    public interface IProfileRepository
    {
        IQueryable<Profile> GetProfiles();
        Profile GetProfile(Guid id);
        void CreateProfile(Profile profile);
    }
}