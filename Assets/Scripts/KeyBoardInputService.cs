using UnityEngine;

public class KeyBoardInputService : IInputService
{
    public bool isJumpPressed => Input.GetKeyDown(KeyCode.W);
    public float moveDirection => Input.GetAxis("Horizontal");
}