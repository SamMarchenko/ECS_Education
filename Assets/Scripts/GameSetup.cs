using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    [Game, Unique]
    public class GameSetup : ScriptableObject
    {
        public GameObject Player;
    }
}