using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    public GameObject airFlow;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            Debug.Log("Hit :(");
            
        }
    }
}
