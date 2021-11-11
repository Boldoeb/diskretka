using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSpawner : MonoBehaviour
{
    public bool spawn = true;
    public Transform spawnPos;
    [SerializeField] GameObject Passanger0;


    private void Update()
    {
        if (spawn == true) StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        spawn = false;
        Vector3 pos = spawnPos.position;
        pos = new Vector3(spawnPos.position.x, 1.1f, spawnPos.position.z);
        GameObject newPassanger1 = Instantiate(Passanger0, pos, Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        spawn = true;
    }
}
