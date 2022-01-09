using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    public float leftBound = -5; 
    public float speed = 10.0f;
    public PlayerMovement playerMovementScripts;
    // Start is called before the first frame update
    void Start()
    {
        playerMovementScripts = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
	{
		if (playerMovementScripts.gameOver == false )
		{
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }
		if (gameObject.CompareTag("obstacle") && leftBound > gameObject.transform.position.x)
		{
            Destroy(gameObject);
		}
    }
}
