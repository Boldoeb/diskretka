using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassangersRaycasting : MonoBehaviour
{
    private float rayDistance = 1;


    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, rayDistance))
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
