using DefaultNamespace;
using Entitas;
using UnityEngine;

namespace Services
{
    public class UnityViewService : IViewService
    {
        public IViewController LoadAsset(Contexts contexts, IEntity entity, string assetName)
        {
            var viewGO = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/" + assetName));
            if (viewGO == null)
                return null;
            
            var viewController = viewGO.GetComponent<IViewController>();
            if (viewController != null)
                viewController.InitView(contexts, entity);
            
            return viewController;
        }
    }
}