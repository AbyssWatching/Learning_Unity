using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //used for jump power
    private Rigidbody playerRB;

    //used for playing music baby
    private AudioSource playerAudio;
    
    //used for checking player position 
    private bool isOnGround = true;
    
    //used for player animation baby
    private Animator playerAnim;

    //how strong gravity multiplier is
    public float gravityMod = 1.2f;
    
    //how stronk the jump is
    public float jumpForce = 10.0f;

    //check game state  
    public bool gameOver = false;
    
    //adding in some effeccts
    public ParticleSystem smokeBomb;
    public ParticleSystem kickDirt;
    public AudioClip jumpAudio;
    public AudioClip crashAudio;

    // Start is called before the first frame update
    void Start()
    {
        //grabbing some components
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        //some gravity maths
        Physics.gravity *= gravityMod;

        //kick dirt son!
        kickDirt.Play();


        
    }

    // Update is called once per frame
    void Update()
    {
        //annie is it ok to jump
		if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
		{
            //jumping stuff

            //telling unity what to do cause it's a bottom
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
            //gotta see where the collider is boi
            isOnGround = false;
            
            //your triggering the player ;p 's jump animation
            playerAnim.SetTrigger("Jump_trig");
            
            //can't kick dirt while FLYING son
            kickDirt.Stop();
            
            //can you hear him jumping
            playerAudio.PlayOneShot(jumpAudio, 1.0f);

        }
        
    }
    //what happens when an unmovable object meets an unstoppable force
    //jk um this is stuff happeneing on collision
	private void OnCollisionEnter(Collision collision)
	{
        //if the player lands "safely" bwahahaha
		if (collision.gameObject.CompareTag("ground"))
		{
            //well we go back to buisness as usuall
            isOnGround = true;
            kickDirt.Play();
		}
        //BUT WHAT IF HE FUCKS UP BWAHAHAHA
		else if(collision.gameObject.CompareTag("obstacle"))
		{
            //just a gameover... in the debugger and variable
            Debug.Log("GAME OVER");
            gameOver = true;

            //play that funcky music ahem ahem person who is melonin challanged
            playerAudio.PlayOneShot(crashAudio);

            //play those animations
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            smokeBomb.Play(true);

            //but not this one cause the only thing you are kicking up is dust
            kickDirt.Stop();
		}

	}
}

