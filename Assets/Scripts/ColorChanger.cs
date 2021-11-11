using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public Transform spawnPos;
    [SerializeField] GameObject Passanger1;
    [SerializeField] GameObject Passanger2;
    [SerializeField] GameObject Passanger3;
    [SerializeField] GameObject Passanger4;
    [SerializeField] GameObject Passanger5;



    IEnumerator Spawn()
    {
        int n;
        n = Random.Range(1, 6);
        Vector3 pos = spawnPos.position;
        pos = new Vector3(spawnPos.position.x, 1.1f, spawnPos.position.z+ 0.8f);
        switch (n)
        {
            case 1:
                GameObject newPassanger1 = Instantiate(Passanger1, pos, Quaternion.identity);
                break;
            case 2:
                GameObject newPassanger2 = Instantiate(Passanger2, pos, Quaternion.identity);
                break;
            case 3:
                GameObject newPassanger3 = Instantiate(Passanger3, pos, Quaternion.identity);
                break;
            case 4:
                GameObject newPassanger4 = Instantiate(Passanger4, pos, Quaternion.identity);
                break;
            case 5:
                GameObject newPassanger5 = Instantiate(Passanger5, pos, Quaternion.identity);
                break;
        }
        yield return new WaitForSeconds(1);
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Spawn());
        Destroy(other.gameObject);
    }
}
