using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float Speed;
    public GameObject walk;
    public GameObject fly;
    public int moveSwitch = 0;
    public Rigidbody rb;
    bool onGround = true;
    public float jumpForce = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();

    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0, ver);
        playerMovement = Vector3.ClampMagnitude(playerMovement, 1) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if (Input.GetButtonDown("Jump") && onGround == true)
        {
            rb.velocity = Vector3.up * jumpForce;
            onGround = false;

        }
    }

    
    void Update()
    {
        
    }
}
    

