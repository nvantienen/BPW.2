using UnityEngine;

public class ThirdPersonFlyingController : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 movement;
    private Rigidbody rb;
    public float jumpForce;
    private Transform cam;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cam = FindObjectOfType<Camera>().transform;
    }
    void FixedUpdate()
    {
        Vector3 forward = Vector3.Scale(new Vector3(1, 1, 1), cam.forward);
        Vector3 right = Vector3.Scale(new Vector3(1, 1, 1), cam.right);
        movement = (forward * Input.GetAxis("Vertical") + right * Input.GetAxis("Horizontal")).normalized * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

    }

         
}


  



