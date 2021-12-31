using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRB;
    public float gravityMod = 1.2f;
    public float jumpForce = 10.0f;
    private bool isOnGround = true;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
		{
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
        
    }
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("ground"))
		{
            isOnGround = true;
		}
		else if(collision.gameObject.CompareTag("obstacle"))
		{
            Debug.Log("GAME OVER");
            gameOver = true;
		}
	}
}

