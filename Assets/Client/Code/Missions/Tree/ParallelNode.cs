using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using SaintsField;
using UnityEngine;

namespace Client.Code.Missions.Tree
{
    [Serializable]
    public struct ParallelNode : IMissionTreeNode
    {
        [SerializeReference, ReferencePicker] public List<IMissionTreeNode> Nodes;

        public UniTask StartAsync(CancellationToken ctsToken)
        {
            foreach (var node in Nodes)
                node.StartAsync(ctsToken).Forget();
            return UniTask.CompletedTask;
        }
    }
}