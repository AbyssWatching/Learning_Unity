using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //the speed at which the vehilce is moving
    public float speed = 15.0F;
    //the speed at which it will turn
    public float turnSpeed;
    // Start is called before the first frame update

    public float horizontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
