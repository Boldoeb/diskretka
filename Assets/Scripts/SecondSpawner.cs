using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSpawner : MonoBehaviour
{
    public Transform spawnPos;
    [SerializeField] GameObject Passanger0;
    [SerializeField] int stationNum;

    


    private void Start()
    {
        switch (stationNum)
        {
            case 1:
                stationNum = 21;
                break;
            case 2:
                stationNum = 12;
                break;
            case 3:
                stationNum = 15;
                break;
            case 4:
                stationNum = 7;
                break;
            case 5:
                stationNum = 3;
                break;
        }
        StartCoroutine(Spawn(stationNum));
    }

    
    IEnumerator Spawn(int st)
    {
        for (int i = 0; i < st; i++)
        {
            Vector3 pos = spawnPos.position;
            pos = new Vector3(spawnPos.position.x, 1.1f, spawnPos.position.z);
            GameObject newPassanger1 = Instantiate(Passanger0, pos, Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
