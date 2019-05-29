using UnityEngine;

public class playerJump : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce = 10f;
    public bool onGround = true;


    private void Awake()
    {
        rb = GameObject.Find("Player").GetComponent<Rigidbody>();
    }


    void Update()
    {

        if (Input.GetButtonDown("Jump") && onGround == true)
        {
            rb.velocity = Vector3.up * jumpForce;
            onGround = false;

        }
    
    }

    private void OnTriggerEnter(Collider other)
    {
        onGround = true;

    }
}
