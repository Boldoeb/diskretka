using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    BusMoving bus;
    public GlobalObserver observer;
    public int station;
    public int poop;
    [SerializeField] public GameObject Passanger1;
    [SerializeField] public GameObject Passanger2;
    [SerializeField] public GameObject Passanger3;
    [SerializeField] public GameObject Passanger4;
    [SerializeField] public GameObject Passanger5;

    private void OnTriggerStay(Collider other)
    {
        int num = other.gameObject.GetComponent<BusMoving>().num;
        
      //  if (observer.buses[num, station] != 5)
      //     other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
       if ( ((poop == 1)  && ((observer.buses[num,4] == 5)|| (observer.buses[num, 3] == 5)|| (observer.buses[num, 2] == 5)|| (observer.buses[num, 1] == 5)|| (observer.buses[num, 0] == 5))) || ((poop == 0)  &&  (observer.buses[num, station] == 0)))
            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
    }


    private void OnTriggerExit(Collider other)
    {
        if ((station == 0) && (observer.numpass[station]>0))
        {
            observer.SpawnBus();
        }
        observer.isBusStation[station] = false;
    }



    private void OnTriggerEnter(Collider other)
    {
        
        int num = other.gameObject.GetComponent<BusMoving>().num;
        observer.isBusStation[station] = true;

        if (poop == 1)
            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        else
        {
            Debug.Log(observer.buses[num, station]);
            if (observer.buses[num, station] > 0)
            {
                if (observer.buses[num, station] > 0)
                    observer.buses[num, station]--;
                    other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                StartCoroutine(Spawn(num));
            }
        }
    }
    IEnumerator Spawn(int num)
    {
        for (int i = 0; i < observer.buses[num, station]+1; i++)
        {
            Vector3 pos = gameObject.transform.position;
            pos = new Vector3(pos.x - 3, 1.1f, pos.z - 3);
            switch (station)
            {
                case 1:
                    GameObject newPassanger1 = Instantiate(Passanger1, pos, Quaternion.identity);
                    newPassanger1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
                    break;
                case 2:
                    GameObject newPassanger2 = Instantiate(Passanger2, pos, Quaternion.identity);
                    newPassanger2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
                    break;
                case 3:
                    GameObject newPassanger3 = Instantiate(Passanger3, pos, Quaternion.identity);
                    newPassanger3.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
                    break;
                case 4:
                    GameObject newPassanger4 = Instantiate(Passanger4, pos, Quaternion.identity);
                    newPassanger4.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
                    break;
                case 5:
                    GameObject newPassanger5 = Instantiate(Passanger5, pos, Quaternion.identity);
                    newPassanger5.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
                    break;
            }
            yield return new WaitForSeconds(1.5f);

        }

    }
}
