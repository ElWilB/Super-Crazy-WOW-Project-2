using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Player Controls")]
    public float playerSpeed = 5.0f;
    public float gravityValue = Physics.gravity.y;
    public float jumpVelocity = 5f;

    public CharacterController controller;
    private Vector3 playerVelocity;

    [Header("Input Actions")]
    public InputActionReference moveAction;
    public InputActionReference jumpAction;

    private void OnEnable() // This is new input system stuffs
    {
        moveAction.action.Enable();
        jumpAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
        jumpAction.action.Disable();
    }

    void Start()
    {

    }

    void Update()
    {
        // Apply gravity
        playerVelocity.y += gravityValue * Time.deltaTime;

        if (controller.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }

        // Read input
        Vector2 input = moveAction.action.ReadValue<Vector2>();

        // Convert input to Vector3
        Vector3 move = new Vector3(input.x, 0, 0);
        move = Vector3.ClampMagnitude(move, 1f);

        // Jump check
        if (jumpAction.action.WasPressedThisFrame() && controller.isGrounded)
        {
            playerVelocity.y = jumpVelocity;
        }

        // Apply all movement
        Vector3 finalMove = (move * playerSpeed) + (playerVelocity.y * Vector3.up);
        controller.Move(finalMove * Time.deltaTime);
    }
}
