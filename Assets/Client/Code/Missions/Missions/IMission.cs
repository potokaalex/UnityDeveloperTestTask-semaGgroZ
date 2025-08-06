using System.Threading;
using Cysharp.Threading.Tasks;

namespace Client.Code.Missions.Missions
{
    public interface IMission
    {
        UniTask StartAsync(CancellationToken ctsToken);
    }
}