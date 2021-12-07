using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMoving : MonoBehaviour
{
    public int[,] buses = new int[15, 5];
    public int num;
    public GlobalObserver observer;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
    }

}
