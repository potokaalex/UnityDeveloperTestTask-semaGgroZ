using System.Threading;
using Client.Code.Missions.Tree;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Client.Code.Missions
{
    public class MissionsRunner : MonoBehaviour
    {
        public MissionsTreeConfig Tree;
        private readonly CancellationTokenSource _cts = new();

        public void Start()
        {
            try
            {
                Tree.Root.StartAsync(_cts.Token).Forget();
            }
            catch
            {
                // ignored
            }
        }

        public void OnDestroy() => _cts.Cancel();
    }
}