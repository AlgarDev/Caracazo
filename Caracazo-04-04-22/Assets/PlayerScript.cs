using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    float verticalSpeed = 5f;
    [SerializeField]
    float horizontalSpeed = 5f;
    private Rigidbody2D myRigidBody2D;
    float initialVerticalSpeed;
    float initialHorizontalSpeed;
    [SerializeField]
    Transform InteractCheckPoint;
    private Collider2D[] InteractCollider = new Collider2D[1];
    [SerializeField]
    private LayerMask NPCLayerMask;
    [SerializeField]
    public UnityEvent Talking;
    [SerializeField]
    private bool canMove = true;
    [SerializeField]
    private Canvas myCanvas;

    void Awake()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        initialVerticalSpeed = verticalSpeed;
        initialHorizontalSpeed = horizontalSpeed;

    }

    void Start()
    {
        StartCoroutine(Dialog());
    }

    void Update()
    {
        if (canMove == true)
        {

            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            if ((verticalInput * verticalSpeed) != 0)
            {
                horizontalSpeed = 0;
            }
            else if (horizontalInput * horizontalSpeed != 0)
            {
                verticalSpeed = 0;
            }
            else
            {
                verticalSpeed = initialVerticalSpeed;
                horizontalSpeed = initialHorizontalSpeed;
            }
            
            /*if((horizontalInput != 0 && verticalSpeed != 0) || (horizontalSpeed !=0 && verticalInput != 0))
            {
                horizontalInput = 0;
                verticalInput = 0;
            }*/

            myRigidBody2D.velocity = new Vector2(horizontalInput * horizontalSpeed, verticalInput * verticalSpeed);



            if (horizontalInput < 0f)
            {
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.z = 180;
                transform.rotation = Quaternion.Euler(rotationVector);
            }

            if (horizontalInput > 0f)
            {
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.z = 0;
                transform.rotation = Quaternion.Euler(rotationVector);
            }

            if (verticalInput < 0f)
            {
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.z = 270;
                transform.rotation = Quaternion.Euler(rotationVector);
            }

            if (verticalInput > 0f)
            {
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.z = 90;
                transform.rotation = Quaternion.Euler(rotationVector);
            }
        }

        if ((Physics2D.OverlapPointNonAlloc(InteractCheckPoint.position, InteractCollider, NPCLayerMask) == 1) && Input.GetKeyDown(KeyCode.E))
        {

            Talking.Invoke();
        }



    }

    public void StopMovement()
    {
        canMove = false;
    }

    public void ResumeMovement()
    {
        canMove = true;
    }


    public IEnumerator Dialog()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            if (canMove == false)
            {
                myCanvas.enabled = false;
                ResumeMovement();

            }
        }
    }
}
