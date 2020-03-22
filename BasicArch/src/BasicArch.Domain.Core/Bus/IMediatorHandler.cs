using System.Threading.Tasks;
using BasicArch.Domain.Core.Commands;

namespace BasicArch.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}