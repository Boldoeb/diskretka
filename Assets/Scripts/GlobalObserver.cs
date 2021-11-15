using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalObserver : MonoBehaviour
{
    private int[,] obstable = { { 5, 4, 3, 4, 3 }, { 0, 3, 2, 4, 3 }, { 0, 0, 4, 5, 6 }, { 0, 0, 0, 3, 4 }, { 0, 0, 0, 0, 3 } };
    bool first = true;
    private void FixedUpdate()
    {
        if (first == false)
        StartCoroutine(Main());
    }
    private void Start()
    {
        StartCoroutine(TriggerStart());
    }

    private IEnumerator TriggerStart()
    {
        
        if (first == true)
        yield return new WaitForSeconds(25);
        first = false;

    }
   
    private IEnumerator Main()
    {
        yield return new WaitForSeconds(5555);
    }
    private IEnumerator CheckStation()
    {
        yield return new WaitForSeconds(25);
    }
}
