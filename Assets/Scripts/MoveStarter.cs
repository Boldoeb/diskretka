using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStarter : MonoBehaviour
{
    public int station;
    public int passanger;
    private int allowedPassanger = 4;

    public GlobalObserver observer;
    private int i = 0; 
    private void OnTriggerEnter  (Collider other)
    {
        if (observer.obstable[0,passanger] == 0)
        {
            allowedPassanger--;
        }
        Debug.Log(observer.buses[i, passanger]);
        Debug.Log(observer.obstable[0, passanger]);
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        if ((observer.buses[i, passanger] < 5) & (observer.obstable[0,passanger]!= 0) & (passanger == allowedPassanger))
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

    private void OnCollisionExit()
    {
        
    }

}
