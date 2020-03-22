using System;
using BasicArch.Domain.Core.Commands;

namespace BasicArch.Domain.Commands
{
    public class CreateProfileCommand : Command
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
    }
}