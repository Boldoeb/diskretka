using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusEnter : MonoBehaviour
{
    public GlobalObserver observer;
    private void OnTriggerStay(Collider other)
    {

        if ((other.gameObject.tag == "Passenger2") || (other.gameObject.tag == "Passenger1") || (other.gameObject.tag == "Passenger3") || (other.gameObject.tag == "Passenger4") || (other.gameObject.tag == "Passenger5"))
        { 
        Destroy(other.gameObject);
        observer.buses[0, 4]++; }
    }

}
