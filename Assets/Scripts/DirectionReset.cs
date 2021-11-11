using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionReset : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
    }
}
