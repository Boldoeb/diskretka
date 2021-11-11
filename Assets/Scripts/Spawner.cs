using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    private int[,] table = new int[5, 5];
    [SerializeField] GameObject Passanger1;
    [SerializeField] GameObject Passanger2;
    [SerializeField] GameObject Passanger3;
    [SerializeField] GameObject Passanger4;
    [SerializeField] GameObject Passanger5;
    private void Start()
    {
    //    for (int i = 0; i < 5; i++)
    //        for (int j = 0; j < 5; j++)
    //            table[i, j] = Random.Range(1, 6);
    }

    private void OnTriggerEnter()
    {
            StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        int n;
        for (int i = 0; i < 10; i++) {
            n = Random.Range(1, 6);
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
