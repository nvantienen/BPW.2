using UnityEngine;
using System.Collections;

public class moveSwitch : MonoBehaviour

{
    private ThirdPersonFlyingController flying;
    private ThirdPersonCharacterController walking;
    public Rigidbody rb;



    private void Awake()
    {
        flying = GetComponent<ThirdPersonFlyingController>();
        walking = GetComponent<ThirdPersonCharacterController>();
        rb = GetComponent<Rigidbody>();
    }

   

    void Update()
    {

    }

    public void FlyingOn(float duration)
    {
        StartCoroutine(fly(duration));
    }

        IEnumerator fly(float duration)
    {
        flying.enabled = true;
        walking.enabled = false;
        rb.useGravity = false;


        yield return new WaitForSeconds(duration);

        flying.enabled = false;
        walking.enabled = true;
        rb.useGravity = true;

    }
}