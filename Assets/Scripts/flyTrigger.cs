using UnityEngine;

public class flyTrigger : MonoBehaviour
{
    public moveSwitch playerFlying;
    // Start is called before the first frame update
    void Start()
    {
        playerFlying = GameObject.Find("Player").GetComponent<moveSwitch>();
    }


    private void OnTriggerEnter(Collider other)
    {
        playerFlying.FlyingOn(5f);
    }
}
