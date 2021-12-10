using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //the speed at which the vehilce is moving well a portion of that
    private float speed = 15.0F;
    //a part of the function for speed at which it will turn
    private float turnSpeed = 25.0f;
    // Start is called before the first frame update

    private float horizontalInput;

    private float verticleInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks for a key input from specific things but to go forward or back
        horizontalInput = Input.GetAxis("Horizontal");
        //also checks for key input but to turn the vehicle
        verticleInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticleInput);

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);


    }
}
