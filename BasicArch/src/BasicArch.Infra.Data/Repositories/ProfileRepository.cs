using System;
using System.Linq;
using BasicArch.Domain.Interfaces;
using BasicArch.Domain.Models;
using BasicArch.Infra.Data.Context;

namespace BasicArch.Infra.Data.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly BasicArchDbContext _dbContext;

        public ProfileRepository(BasicArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateProfile(Profile profile)
        {
            _dbContext.Add(profile);
            _dbContext.SaveChanges();
        }

        public Profile GetProfile(Guid id)
        {
            return _dbContext.Profiles.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Profile> GetProfiles()
        {
            return _dbContext.Profiles;
        }
    }
}