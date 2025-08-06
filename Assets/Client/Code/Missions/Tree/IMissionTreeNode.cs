using Cysharp.Threading.Tasks;

namespace Client.Code.Missions.Tree
{
    public interface IMissionTreeNode
    {
        UniTask RunAsync();
    }
}