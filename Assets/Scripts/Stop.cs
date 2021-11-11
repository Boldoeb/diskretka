using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject bus;
    public int direct;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        bus.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
        StartCoroutine(ExecuteAfterTime());
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(500);

        switch (direct) {
            case 0:
                bus.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
                break;
            case 1:
                bus.GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);
                break;
        }
    }

}
