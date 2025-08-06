using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Client.Code.Missions.Missions
{
    [CreateAssetMenu(menuName = "Client/Missions/LogMission", fileName = "LogMission", order = 0)]
    public class LogMission : MissionBase
    {
        public override UniTask StartAsync()
        {
            Debug.Log(Name);
            return UniTask.CompletedTask;
        }
    }
}