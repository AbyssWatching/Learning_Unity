using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //var for horiontl input
    public float horInput;
    //var for speed of horizontal movement
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets the horizontal input from getAxis
        horInput = Input.GetAxis("Horizontal");
        //moves GO right or left dependent on button press
        transform.Translate(Vector3.right * Time.deltaTime * speed * horInput);

		if (Input.GetKeyDown(KeyCode.S))
		{
            transform.Rotate(Vector3.up, 180);
		}
    }
}
