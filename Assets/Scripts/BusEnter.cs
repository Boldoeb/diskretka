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
            switch (other.gameObject.tag)
            {
                case "Passenger1":
                    observer.buses[gameObject.GetComponent<BusMoving>().num, 0]++;
                    break;
                case "Passenger2":
                    observer.buses[gameObject.GetComponent<BusMoving>().num, 1]++;
                    break;
                case "Passenger3":
                    observer.buses[gameObject.GetComponent<BusMoving>().num, 2]++;
                    break;
                case "Passenger4":
                    observer.buses[gameObject.GetComponent<BusMoving>().num, 3]++;
                    break;
                case "Passenger5":
                    observer.buses[gameObject.GetComponent<BusMoving>().num, 4]++;
                    break;

            }
         }
    }

}
