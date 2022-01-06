using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //just a position I WONDER/WANDER why we need that
    private Vector3 obstaclePos = new Vector3(25, 1.2f, 0);
    
    //this will be implemented later
    private float Rando;
    
    //THE BOLDER! 
    public GameObject obstacle;

    //Time to make THE BOLDER!
    public float startTime = 2;

    //SCRIPT
    public PlayerMovement PlayerMovementScript;
    
    // Start is called before the first frame update
    void Start()
    {
        //this will be implemented later
        Rando = Random.Range(.5f, 2.5f);

        //Repeatedly spawns... THE BOLDER
        InvokeRepeating("SpawnRocks", startTime, 2);
        
        //WHAT ARE MY LINES, also the script
        PlayerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //spawn Rocks hmmm wander what this does
    void SpawnRocks() 
    {
        //if it's not over throw... THE BOLDER
        if (PlayerMovementScript.gameOver == false)
        {
            Instantiate(obstacle, obstaclePos, obstacle.transform.rotation);
        }
    }
}
