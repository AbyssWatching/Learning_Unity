using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //we will set it in post... start you'll see
    private Vector3 startPos;
    private float repeatWidth;


    // Start is called before the first frame update
    void Start()
    {
        //the starting position
        startPos = transform.position;
        // half the length of the background what could that be for
        repeatWidth = GetComponent<BoxCollider>().size.x/2;
        Debug.Log(repeatWidth);
    }

    // Update is called once per frame
    void Update()
    {
        //that's when the halfway point is, no one will no
		if (transform.position.x < startPos.x - repeatWidth)
		{
            transform.position = startPos; 
		}
    }
}
