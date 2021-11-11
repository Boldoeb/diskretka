using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ColorChanger : MonoBehaviour
{

    public Transform spawnPos;
    [SerializeField] GameObject Passanger1;
    [SerializeField] GameObject Passanger2;
    [SerializeField] GameObject Passanger3;
    [SerializeField] GameObject Passanger4;
    [SerializeField] GameObject Passanger5;
    [SerializeField] GameObject bug;
    private int[,] pos = new int[5, 5];
    private int i, j;

    private void Start()
    {
        //string[] lines = File.ReadAllLines("Pos.txt");
        //int[,] num = new int[lines.Length, lines[0].Split(' ').Length];
        //for (int i = 0; i < lines.Length; i++)
        //{
        //     string[] temp = lines[i].Split(' ');
        //       for (int j = 0; j < temp.Length; j++)
        //             num[i, j] = Convert.ToInt32(temp[j]);
        //      }
    }

    IEnumerator Spawn()
    {
        int n = Random.Range(1, 6);
        Vector3 pos = spawnPos.position;
        pos = new Vector3(spawnPos.position.x, 1.1f, spawnPos.position.z+ 0.8f);
        switch (n)
        {
            case 0:
                GameObject bug1 = Instantiate(bug, pos, Quaternion.identity);
                break;
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
