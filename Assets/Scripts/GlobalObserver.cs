using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalObserver : MonoBehaviour
{
    public int[,] obstable = { { 5, 4, 3, 4, 5 }, { 0, 3, 2, 4, 3 }, { 0, 0, 4, 5, 6 }, { 0, 0, 0, 3, 4 }, { 0, 0, 0, 0, 3 } };
    public int[,] buses = new int[15,5];
    public GameObject bus;
    public int[] numpass = { 21, 12, 15, 7, 3 };
    private int i = 1;
    public bool[] isBusStation = {false,false,false,false,false,false };  
    public bool first = true;
    private void FixedUpdate()
    {
    }
    private void Start()
    {
        StartCoroutine(TriggerStart());
    }

    public void SpawnBus()
    {
        GameObject newbus = Instantiate(bus, new Vector3(773, 2.5f, 504), Quaternion.identity);
        newbus.GetComponent<BusMoving>().num = i;
        i++;
    }

    private IEnumerator TriggerStart()
    {
        
        if (first == true)
        yield return new WaitForSeconds(5);
        first = false;
        Debug.Log("Start");

    }
}
