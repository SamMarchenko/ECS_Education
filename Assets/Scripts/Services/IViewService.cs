using DefaultNamespace;
using Entitas;

namespace Services
{
    public interface IViewService
    {
        IViewController LoadAsset(Contexts contexts, IEntity entity, string assetName);
    }
}