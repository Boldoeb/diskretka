using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassStop : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        other.gameObject.GetComponent<Rigidbody>().mass = 1000000000000;
    }
}
