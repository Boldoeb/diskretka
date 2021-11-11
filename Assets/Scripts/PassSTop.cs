using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassSTop : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        other.gameObject.GetComponent<Rigidbody>().mass = 1000000000000;
    }

    private void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        StartCoroutine(destruct(other));
    }

    IEnumerator destruct(Collider other)
    {
        yield return new WaitForSeconds(5);
        Destroy(other.gameObject);
    }
}
