using UnityEngine;

public class Movement : MonoBehaviour
{
    //variables
    private Rigidbody rb;

    public float speed = 8.5f;
    public float jumpForce = 26f;
    public float gravity = 6f;
    public float lookSpeed = 3.5f;

    private bool isGrounded = false;
    private bool won = false;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        //float dirY = Input.GetAxis("Jump") * jumpForce;
        // Vector3 jumpDir = new Vector3(0f, dirY, 0f);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            //  Debug.Log();
        }

        if (!won)
        {
            float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;

            //rotate based on mouse input
            Camera.main.transform.Rotate(0f, mouseX, 0f, Space.World);
            Camera.main.transform.Rotate(-mouseY, 0f, 0f, Space.Self);
        }
    }

    private void FixedUpdate()
    {
        //put physics, function called every number of seconds

        float dirX = Input.GetAxis("Horizontal") * speed;
        float dirZ = Input.GetAxis("Vertical") * speed;

        Vector3 moveDir = new Vector3(dirX, 0f, dirZ);
        // makes it so that 'forward' changes based on your camera is looking
        moveDir = Camera.main.transform.TransformDirection(moveDir);
        //moveDir.y = 0f;
        moveDir.y = rb.velocity.y;
        //rb.AddForce(moveDir * speed);
        rb.velocity = moveDir;

        if (!isGrounded)
        {
            rb.AddForce(Physics.gravity * gravity, ForceMode.Acceleration);
        }

        //if (won)
        // Debug.LogError("WIN");
    }

    private void OnCollisionEnter(Collision other)
    {
        Floor ground = other.gameObject.GetComponent<Floor>();
        if (ground)
        {
            isGrounded = true;
        }

        Winner win = other.gameObject.GetComponent<Winner>();
        if (win)
        {
            won = true;
            //win con screen
            //from https://answers.unity.com/questions/747872/freeze-rigidbody-position-in-script.html
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ
                | RigidbodyConstraints.FreezeRotation;
        }
    }

    private void OnCollisionStay(Collision other)
    {
        Floor ground = other.gameObject.GetComponent<Floor>();
        if (ground)
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        Floor ground = other.gameObject.GetComponent<Floor>();
        if (ground)
        {
            isGrounded = false;
        }
    }
}