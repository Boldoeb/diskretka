using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassangersMove : MonoBehaviour
{
    public GameObject thisPass;



    private void Start()
    {
        thisPass.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
    }


}