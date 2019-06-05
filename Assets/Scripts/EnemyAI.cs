using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Animator animator;

    public GameObject Player;
    public float bulletStart = 0.5f;
    public float bulletInterval = 0.5f;
    public GameObject enemyBullet;
    public GameObject turret;


    public GameObject GetPlayer()
    {
        return Player;
    }

    public void Fire()
    {
        GameObject b = Instantiate(enemyBullet, turret.transform.position, turret.transform.rotation);
        b.GetComponent<Rigidbody>().AddForce(turret.transform.forward * 500);

    }

    public void StopFiring()
    {
        CancelInvoke("Fire");
    }

    public void StartFiring()
    {
        InvokeRepeating("Fire", bulletStart, bulletInterval);
    }


    void Start()
    {
        animator = GetComponent<Animator>();
    
    }

    void Update()
    {
        animator.SetFloat("distance", Vector3.Distance(transform.position, Player.transform.position));

    }
}
