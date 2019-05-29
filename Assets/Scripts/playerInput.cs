using UnityEngine;

public class playerInput : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public float range;
    

    // Update is called once per frame
    void Update()
    {
        Timer();
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject wind = Instantiate(bullet, firePoint.position, firePoint.rotation);
            Destroy(wind, range);
        }

    }
    
    float Timer()
    {
        return timeStamp -= Time.deltaTime;
    }
}
