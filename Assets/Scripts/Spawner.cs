using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public int[,] table = new int[5, 5];
    [SerializeField] GameObject Passanger1;
    [SerializeField] GameObject Passanger2;
    [SerializeField] GameObject Passanger3;
    [SerializeField] GameObject Passanger4;
    [SerializeField] GameObject Passanger5;
    public GlobalObserver observer;
    public int busNum = 0, stationNum;
    private void Start()
    {
    }

    private void OnTriggerEnter()
    {
        if (observer.buses[busNum, stationNum] > 0)
            StartCoroutine(Spawn(observer.buses[busNum, stationNum],stationNum));
    }
    IEnumerator Spawn(int i,int n)
    {
        for (int i1 = i; i ==0; i--) {
            Vector3 pos = spawnPos.position;
            pos = new Vector3(pos.x - 3, 1.1f, pos.z - 3);
            switch (n)
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
