using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Client.Code.Missions.Missions
{
    public abstract class MissionBase : ScriptableObject, IMission
    {
        public string Name;
        public event Action OnStarted;
        public event Action OnFinished;

        public void Start() => StartAsync().Forget();

        private async UniTaskVoid StartAsync()
        {
            OnStarted?.Invoke();
            await Run();
            OnFinished?.Invoke();
        }

        protected abstract UniTask Run();
    }
}