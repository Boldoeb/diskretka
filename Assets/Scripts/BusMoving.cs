using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMoving : MonoBehaviour
{
    public GameObject bus;
    void Start()
    {
        bus.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
    }
}
