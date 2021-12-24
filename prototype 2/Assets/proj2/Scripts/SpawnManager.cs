using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPre;
    public int xRange = 20;
    public int yrange = 0;
    public int zRange = 20;
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.S))
		{
            SpawnAnimal();
		}
        
    }
    void SpawnAnimal() 
    {

        int choosenOne = Random.Range(0, animalPre.Length);
        int rando = Random.Range(-xRange, xRange);
        Vector3 spawnRange = new Vector3(rando, yrange, zRange);
        Instantiate(animalPre[choosenOne], spawnRange, animalPre[choosenOne].transform.rotation);
    }
}
