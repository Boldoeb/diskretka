using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassangersMove : MonoBehaviour
{
    public Transform TargetPos;

    public void Start()
    {
        TargetPos.position = new Vector3 (transform.parent.position.x - 5, transform.parent.position.y, transform.parent.position.z + 3);
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, TargetPos.position, 5);
    }


}
