using System;
using BasicArch.Domain.Core.Events;

namespace BasicArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        public Command()
        {
            Timestamp = DateTime.UtcNow.ToLocalTime();
        }
    }
}