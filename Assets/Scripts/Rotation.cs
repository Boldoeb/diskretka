using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] public int pos;
    public GameObject bus;

    private void OnTriggerEnter()
    {
        switch (pos)
        {
            case 1:
                bus.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -15);
                break;
            case 2:
                bus.GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);
                break;
            case 3:
                bus.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 15);
                break;
            case 4:
                bus.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
                break;
        }
    }
}
