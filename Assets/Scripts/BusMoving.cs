using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMoving : MonoBehaviour
{
    public int[,] buses = new int[15, 5];
    public int num;
    public GlobalObserver observer;
    public GameObject bus;
    void Start()
    {
        bus.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
    }
    private void FixedUpdate()
    {
        if (observer.buses[0, 4] == 5)
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
    }

}
