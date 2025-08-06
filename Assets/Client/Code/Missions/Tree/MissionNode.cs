using System;
using Client.Code.Missions.Missions;
using Cysharp.Threading.Tasks;
using SaintsField;

namespace Client.Code.Missions.Tree
{
    [Serializable]
    public struct MissionNode : IMissionTreeNode
    {
        public SaintsObjInterface<IMission> Mission;
        public int StartDelay;

        public async UniTask RunAsync()
        {
            await UniTask.Delay(StartDelay);
            Mission.I.Start();
        }
    }
}