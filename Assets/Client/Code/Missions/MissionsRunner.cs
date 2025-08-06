using Client.Code.Missions.Tree;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Client.Code.Missions
{
    public class MissionsRunner : MonoBehaviour
    {
        public MissionsTreeConfig Tree;

        public void Start() => Tree.Root.RunAsync().Forget();
    }
}