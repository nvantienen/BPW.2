using UnityEngine;

public class airBoxTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("woooosh c:");
        }  
    }
}
