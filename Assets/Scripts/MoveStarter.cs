using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStarter : MonoBehaviour
{
    public int station;
    public int passanger;
    private int allowedPassanger = 4;
    private int busnum = 0;

    public GlobalObserver observer;

    private void Start()
    {
        passanger--;
    }
    private void OnTriggerEnter(Collider other)
    {
        observer.numpass[station]--;
    }
    private void OnTriggerExit()
    {
        if (observer.obstable[station, passanger] == 0)
        {
            allowedPassanger--;
        };
        if(observer.buses[busnum,passanger] == 5)
        {
            busnum++; 
        }
    }
    private void OnTriggerStay  (Collider other)
    {
        if (observer.isBusStation[station] == true) { 
        Debug.Log(observer.buses[busnum, passanger]);
        Debug.Log(observer.obstable[0, passanger]);
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            if ((observer.buses[busnum, passanger] < 5) & (observer.obstable[station, passanger] != 0) & (passanger == allowedPassanger))
            {

                switch (passanger)
                {
                    case 0:
                        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-3, 0, 3);
                        observer.obstable[passanger, station]--;
                        break;
                    case 1:
                        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-1.5f, 0, 3);
                        observer.obstable[passanger, station]--;
                        break;
                    case 2:
                        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
                        observer.obstable[passanger, station]--;
                        break;
                    case 3:
                        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(1.5f, 0, 3);
                        observer.obstable[passanger, station]--;
                        break;
                    case 4:
                        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 3);
                        observer.obstable[passanger, station]--;
                        break;
                }
                Debug.Log("Moving");
            }
        }
    }
}
