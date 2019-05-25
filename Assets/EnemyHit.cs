using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            Debug.Log("Hit :(");

        }
    }
}
