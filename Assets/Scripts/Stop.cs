using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public int direct;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
        StartCoroutine(ExecuteAfterTime(other));
    }

    IEnumerator ExecuteAfterTime(Collider other)
    {
        yield return new WaitForSeconds(20);

        switch (direct) {
            case 0:
                other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
                break;
            case 1:
                other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);
                break;
        }
    }

}
