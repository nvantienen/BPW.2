using System.Collections;
using UnityEngine;

public class airBoxTrigger : MonoBehaviour
{
    public float blowForce =1f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("woooosh c:");
        }  
        //other.gameObject.transform.Translate(Vector3.up * blowForce * Time.deltaTime, Space.World);

   

        if(other.gameObject.GetComponent<Rigidbody>() != null)
        {
            
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * blowForce* Time.deltaTime * 100);
            Debug.Log("werk pls");
            StartCoroutine("Paralyzed");
        }

    }


    IEnumerator Paralyzed()
    {
        print(Time.time);
        yield return new WaitForSeconds(5f);
        print(Time.time);

    }
}
