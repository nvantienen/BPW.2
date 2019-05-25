using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float Speed;
    public GameObject walk;
    public GameObject fly;
    public int moveSwitch = 0;

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

    }
    void Update()
    {
        
    }
}
    

