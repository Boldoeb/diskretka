using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChanger : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Passenger1") other.GetComponent<Rigidbody>().velocity = new Vector3(6.3f, 0, 3);
        if (other.gameObject.tag == "Passenger2") other.GetComponent<Rigidbody>().velocity = new Vector3(3.3f, 0, 3);
        if (other.gameObject.tag == "Passenger3") other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
        if (other.gameObject.tag == "Passenger4") other.GetComponent<Rigidbody>().velocity = new Vector3(-3.3f, 0, 3);
        if (other.gameObject.tag == "Passenger5") other.GetComponent<Rigidbody>().velocity = new Vector3(-6.3f, 0, 3);
    }
}
