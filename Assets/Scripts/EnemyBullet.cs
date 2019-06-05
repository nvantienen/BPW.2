using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour

{
    public float speed = 10f;
    public GameObject player;
    public float thrust;

    // Start is called before the first frame update

    void Awake()
    {
        player = GameObject.Find("Player");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Debug.Log("Triggered");
             GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
           // collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
                
        }
        Destroy(gameObject);

    }
}
