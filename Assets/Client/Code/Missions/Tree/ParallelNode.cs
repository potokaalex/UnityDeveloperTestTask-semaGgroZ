using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SaintsField;
using UnityEngine;

namespace Client.Code.Missions.Tree
{
    [Serializable]
    public struct ParallelNode : IMissionTreeNode
    {
        [SerializeReference, ReferencePicker] public List<IMissionTreeNode> Nodes;

        public UniTask RunAsync()
        {
            foreach (var node in Nodes)
                node.RunAsync().Forget();
            return UniTask.CompletedTask;
        }
    }
}