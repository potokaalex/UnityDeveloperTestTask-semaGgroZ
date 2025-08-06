using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Client.Code.Missions.Missions
{
    public abstract class MissionBase : ScriptableObject, IMission
    {
        public string Name;

        public abstract  UniTask StartAsync();
    }
}