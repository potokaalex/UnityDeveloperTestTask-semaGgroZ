using System;
using System.Collections.Generic;
using SaintsField;
using UnityEngine;

namespace Client.Code.Missions.Tree
{
    [Serializable]
    public struct ListNode : IMissionTreeNode
    {
        [SerializeReference, ReferencePicker] public List<IMissionTreeNode> List;
    }
}