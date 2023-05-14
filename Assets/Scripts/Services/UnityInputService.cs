using UnityEngine;

namespace Services
{
    public class UnityInputService : IInputService
    {
        public float MoveDirectionX => Input.GetAxis("Horizontal");
        public bool JumpButtonPressed => Input.GetKeyDown(KeyCode.W);
    }
}