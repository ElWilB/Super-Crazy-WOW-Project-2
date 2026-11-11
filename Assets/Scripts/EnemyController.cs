using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyController : MonoBehaviour
{
    [Header("Enemy Controls")]
    public float enemySpeed = 5.0f;
    public float gravityValue = Physics.gravity.y;
    public float jumpVelocity = 5f;

    public CharacterController controller;
    private Vector3 enemyVelocity;
    

    [Header("Animations")]
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    private bool isFacingRight;

    void Update()
    {
        UpdateMovement();

        UpdateAnimationState();
    }

    void UpdateMovement()
    {
        // Apply gravity
        enemyVelocity.y += gravityValue * Time.deltaTime;

        if (controller.isGrounded && enemyVelocity.y < 0)
        {
            enemyVelocity.y = -2f;
        }

        Vector3 move = Vector3.zero;

        // Apply all movement
        Vector3 finalMove = (move * enemySpeed) + (enemyVelocity.y * Vector3.up);
        controller.Move(finalMove * Time.deltaTime);
    }

    void UpdateAnimationState()
    {
        if(isFacingRight == true)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }

        if(controller.isGrounded == false)
        {
            animator.Play("Player_Falling");
        }
        else if (controller.velocity.magnitude > 25555555f)
        {
            animator.Play("Player_Running");
        }
        else
        {
            animator.Play("Player_Idle");
        }
    }
}
