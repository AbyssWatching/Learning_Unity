using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireweapon : MonoBehaviour
{
    //round will be the bullet shot from player
    public GameObject round; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the player presses space bar they will spawn a round!
		if (Input.GetKeyDown(KeyCode.Space))
		{
            Instantiate(round, transform.position, transform.rotation);
		}
        
    }
}
