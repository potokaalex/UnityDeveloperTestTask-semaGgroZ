using System;
using System.Threading;
using Client.Code.Missions.Missions;
using Cysharp.Threading.Tasks;
using SaintsField;

namespace Client.Code.Missions.Tree
{
    [Serializable]
    public class MissionNode : IMissionTreeNode
    {
        public SaintsObjInterface<IMission> Mission;
        public int StartDelay;
        private readonly Timer _timer = new();

        public async UniTask StartAsync(CancellationToken ctsToken)
        {
            ctsToken.Register(_timer.Cancel);
            await _timer.StartAsync(StartDelay * 1000);
            await Mission.I.StartAsync(ctsToken);
        }
    }
}