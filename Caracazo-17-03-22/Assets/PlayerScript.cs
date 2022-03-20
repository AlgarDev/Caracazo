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
    /*[SerializeField]
    public UnityEvent Talking = null;*/
    [SerializeField]
    public InteractableNPC myNPC;

    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        initialVerticalSpeed = verticalSpeed;
        initialHorizontalSpeed = horizontalSpeed;
    }


    void Update()
    {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");


        if (Input.GetButton("Vertical") && (verticalSpeed != 0))
        {
            horizontalSpeed = 0;
        }
        else if (Input.GetButton("Horizontal") && (horizontalSpeed != 0))
        {
            verticalSpeed = 0;
        }
        else
        {
            verticalSpeed = initialVerticalSpeed;
            horizontalSpeed = initialHorizontalSpeed;
        }
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalInput * horizontalSpeed, verticalInput * verticalSpeed);

        if ((Physics2D.OverlapPointNonAlloc(InteractCheckPoint.position, InteractCollider, NPCLayerMask) == 1) && Input.GetKeyDown(KeyCode.E))
        {
            myNPC.Interact();
            //Talking.Invoke();
        }

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

}
