using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    //setting boundaries cause that's important
    public float leftBound = -5; 

    //Can't move to fast or they will get away but move to slow and they will want to be friends;p
    public float speed = 10.0f;
    
    //GET ME THAT SCRIPT BOI
    public PlayerMovement playerMovementScripts;
    
    // Start is called before the first frame update
    void Start()
    {
        //I SAID THE SCRIPT
        playerMovementScripts = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
	{
        //FOR THIS REASON
		if (playerMovementScripts.gameOver == false )
		{
            //If he is alive throw rock at him bwahahaha
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }
        //but destroy the rocks if they miss
		if (gameObject.CompareTag("obstacle") && leftBound > gameObject.transform.position.x)
		{
            Destroy(gameObject);
		}
    }
}
