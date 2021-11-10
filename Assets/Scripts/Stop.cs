using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject bus;
    public int direct;

    private void OnTriggerEnter()
    {
        bus.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
        StartCoroutine(ExecuteAfterTime());
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(0.5f);

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
