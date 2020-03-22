using System;

namespace BasicArch.Domain.Models
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime CreateDate { get; set; }
    }
}