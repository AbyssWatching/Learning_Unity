using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float upperBound = 35.0f;

    private float lowerBound = -10.0f;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperBound) 
        {
            Destroy(gameObject);
		}
		else if (transform.position.z < lowerBound)
		{
            Destroy(gameObject);
		}
        
    }
}
