using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMove : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
    }
}
