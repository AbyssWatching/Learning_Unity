using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float HorInput;

    public float speed = 10.0f;

    public float xbound = 10;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xbound)
		{
            transform.position = new Vector3(-xbound, transform.position.y, transform.position.z);
		}
        if (transform.position.x > xbound)
        {
            transform.position = new Vector3(xbound, transform.position.y, transform.position.z);
        }


        HorInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * speed * HorInput);

		if (Input.GetKeyDown(KeyCode.Space))
		{
            //fire weapon if true
            Instantiate(projectile,transform.position,projectile.transform.rotation);
		}
    }
}
