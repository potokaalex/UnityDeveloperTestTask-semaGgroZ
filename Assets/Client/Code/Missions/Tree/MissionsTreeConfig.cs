using UnityEngine;

namespace Client.Code.Missions.Tree
{
    [CreateAssetMenu(menuName = "Client/Missions/Tree", fileName = "MissionTreeConfig", order = 0)]
    public class MissionsTreeConfig : ScriptableObject
    {
        public ListNode Root;
    }
}