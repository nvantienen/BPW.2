using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    float timeStamp = 5;

    public GameObject airFlow;

    void Update()
    {
        Timer();

    }

    float Timer()
    {
        return timeStamp -= Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            Debug.Log("Hit :(");
           
            
        }
    }
}
