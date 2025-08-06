using System;

namespace Client.Code.Missions.Missions
{
    public interface IMission
    {
        event Action OnStarted;
        event Action OnFinished;
        void Start();
    }
}