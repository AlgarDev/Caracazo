using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private float horizontalWalkSpeed;
    [SerializeField]
    private float verticalWalkSpeed;
    private Rigidbody2D myRigidbody2d;
    [SerializeField]
    private float flipWaitTime = 5;

    private void Awake()
    {
        myRigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(HorizontalFlip), flipWaitTime, flipWaitTime);
    }
    private void Update()
    {
        myRigidbody2d.velocity = new Vector2(horizontalWalkSpeed * transform.right.x, verticalWalkSpeed * myRigidbody2d.velocity.y);
    }

    private void HorizontalFlip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
    private void VerticalFlip()
    {
        transform.Rotate(180f, 0f, 0f);
    }
}
