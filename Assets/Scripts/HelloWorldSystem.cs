using Entitas;
using UnityEngine;

namespace DefaultNamespace
{
    public class HelloWorldSystem : IInitializeSystem
    {
        public void Initialize()
        {
            Debug.Log("Hello world");
        }
    }
}