using System;
using Client.Code.Missions.Missions;
using SaintsField;

namespace Client.Code.Missions.Tree
{
    [Serializable]
    public struct MissionNode : IMissionTreeNode
    {
        public SaintsObjInterface<IMission> Mission;
        public int StartDelay;
    }
}