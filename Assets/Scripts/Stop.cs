using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    BusMoving bus;
    public GlobalObserver observer;
    public int station;
    public int busNum = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (station == 0)
            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        if (observer.buses[busNum, station] > 0)
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            observer.buses[busNum, station] = 0;
        } 
    }
    private void OnTriggerExit()
    {
        if (observer.obstable[0, station] + observer.obstable[1, station] + observer.obstable[2, station] + observer.obstable[3, station] + observer.obstable[4, station] > 0)
            observer.SpawnBus();
    }
}
