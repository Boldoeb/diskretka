using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float j,z;
    public GameObject father;
    public Transform spawnPos;
    [SerializeField] Vector3 range;
    [SerializeField] GameObject Passanger1;
    [SerializeField] GameObject Passanger2;
    [SerializeField] GameObject Passanger3;
    [SerializeField] GameObject Passanger4;
    [SerializeField] GameObject Passanger5;
    [SerializeField] GameObject Passanger6;

    private void Start()
    {
        int[,] table = new int[5,5];

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                table[i, j] = Random.Range(1, 7);

            for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                StartCoroutine(Spawn(table[i, j]));
            }
    }

    IEnumerator Spawn(int n)
    { 
        Vector3 pos = spawnPos.position + new Vector3((range.x - j) ,1.5f, (range.z - z));
        switch (n)
        {
            case 1:
                GameObject newPassanger1 =  Instantiate(Passanger1, pos, Quaternion.identity);
                Passanger1.transform.parent = father.transform;
                break;
            case 2:
                GameObject newPassanger2 =  Instantiate(Passanger2, pos, Quaternion.identity);
                Passanger2.transform.parent = father.transform;
                break;
            case 3:
                GameObject newPassanger3 = Instantiate(Passanger3, pos, Quaternion.identity);
                Passanger3.transform.parent = father.transform;
                break;
            case 4:
                GameObject newPassanger4 = Instantiate(Passanger4, pos, Quaternion.identity);
                Passanger4.transform.parent = father.transform;
                break;
            case 5:
                GameObject newPassanger5 = Instantiate(Passanger5, pos, Quaternion.identity);
                Passanger5.transform.parent = father.transform;
                break;
            case 6:
                GameObject newPassanger6 = Instantiate(Passanger6, pos, Quaternion.identity);
                Passanger6.transform.parent = father.transform;
                break;
        }
        j += 1.2f;
        if (j == 6)
        {
            j = 0;
            z += 1.5f;
        }
        yield return new WaitForSeconds(1);
    }

}
