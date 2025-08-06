using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using SaintsField;
using UnityEngine;

namespace Client.Code.Missions.Tree
{
    [Serializable]
    public struct ChainNode : IMissionTreeNode
    {
        [SerializeReference, ReferencePicker] public List<IMissionTreeNode> Nodes;

        public async UniTask StartAsync(CancellationToken ctsToken)
        {
            foreach (var node in Nodes)
                await node.StartAsync(ctsToken);
        }
    }
}