using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Vector3 startPos;
    public Vector3 endPos;

    private Vector3 targetPos;

    void Awake()
    {
        targetPos = startPos;
    }

    void FixedUpdate()
    {
        Vector3 currentPos = transform.position;

        if (currentPos == startPos)
        {
            targetPos = endPos;
        }
        else if (currentPos == endPos)
        {
            targetPos = startPos;
        }

        Vector3 targetDirection = (currentPos - targetPos).normalized;
    }
}