using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement: MonoBehaviour
{
    [SerializeField]
    private Transform[] points = null;

    private Vector3 startPosition;

    private Vector3 targetPosition;

    private int targetIndex = 1;

    private float startTime = 0f;

    [SerializeField]
    private float duration = 3f;

    public float m_Angle;
    private void Awake()
    {
        startPosition = points[0].position;
        targetPosition = points[targetIndex].position;
    }

    private void Start()
    {
        startTime = Time.time;
        FlipToTarget();
    }

    private void Update()
    {
        float t = (Time.time - startTime) / duration;

        transform.position = Vector3.Lerp(startPosition, targetPosition, t);


        if (t >= 1f)
        {
            MoveToNextPoint();
        }
    }

    private void MoveToNextPoint()
    {
        
        startPosition = targetPosition;
        targetIndex = (targetIndex + 1) % points.Length;
        targetPosition = points[targetIndex].position;
        startTime = Time.time;
        FlipToTarget();
    }

    private void FlipToTarget()
    {
        Vector3 difference = targetPosition - startPosition;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
    }
}
