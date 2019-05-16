using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{

    public float RotationSpeed = 1;
    public Transform Target, Player;
    float MouseX, MouseY;


    public Transform Obstruction;
    float zoomSpeed = 2f;

    void Start()
    {
        Obstruction = Target;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    
   

    void LateUpdate()
    {
        CamControl();
        ViewObstructed();
    }

    void CamControl()
    {
        MouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        MouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        MouseY = Mathf.Clamp(MouseY, -35, 60);

        transform.LookAt(Target);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            Target.rotation = Quaternion.Euler(MouseY, MouseX, 0);
        }
        else
        {
            Target.rotation = Quaternion.Euler(MouseY, MouseX, 0);
            Player.rotation = Quaternion.Euler(0, MouseX, 0);
        }
       
    }

    void ViewObstructed()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, Target.position -transform.position, out hit, 4.5f))
        {
            if (hit.collider.gameObject.tag != "Player")
            {
                Obstruction = hit.transform;
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

                if(Vector3.Distance(Obstruction.position, transform.position) >= 3f && Vector3.Distance(transform.position, Target.position) >=1.5f)

                {
                    transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);

                }
            }
            else
            {
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                if (Vector3.Distance(transform.position, Target.position) < 4.5f)
                {
                    transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
                }
    
            }
        }
    }
}
