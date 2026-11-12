using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour
{
    // Since we've set up a differing movement method anyway, take the animation controls and wire them in here.
    [Header("Enemy Animation Attributes")]
    public CharacterController controller;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    private bool isFacingRight;
    private bool enemyWalking;


    public Vector3 pointB;
    public float timeDelay = 3f;
    public float moveSpeed = 1.2f;

    private void Update()
    {
        UpdateAnimationState();
    }

    // Since I haven't a clue what this actually does (start a routine to follow?), leave it alone.
    // Animations can be handled in the IEnumerator since they need to be, but try to minimize alterations.
    IEnumerator Start()
    {
        var pointA = transform.position;
        while (true)
        {
            enemyWalking = false;
            yield return new WaitForSeconds(timeDelay);
            enemyWalking = true;
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
            enemyWalking = false;
            yield return new WaitForSeconds(timeDelay);
            enemyWalking = true;
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f));
            enemyWalking = false;

        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = moveSpeed / time;
        transform.Rotate(0, 180, 0);
        while (i < 1.0f)
        {
                i += Time.deltaTime * rate;
                thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }

    void UpdateAnimationState()
    {

        if (CatchPlayer.instance.isCaught == true)
        {
            animator.Play("EnemyPoint");
        }
        if (enemyWalking == true)
            {
                animator.Play("EnemyWalk");
            }
            else
            {
                animator.Play("EnemyIdle");
            }
    }
}