using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    private Vector3 obstaclePos = new Vector3(25, 1.2f, 0);
    private float Rando;
    public float startTime = 2;
    public PlayerMovement PlayerMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        Rando = Random.Range(.5f, 2.5f);
        InvokeRepeating("SpawnRocks", startTime, 2);
        PlayerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRocks() 
    {
        if (PlayerMovementScript.gameOver == false)
        {
            Instantiate(obstacle, obstaclePos, obstacle.transform.rotation);
        }
    }
}
