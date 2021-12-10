using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    // GamoObject for now will be VAR play in which we will conect the vehicle to in unity
    public GameObject player;
    // vector3 needs the new keyword when being made also don't forget it needs an xy and z
    private Vector3 offSet = new Vector3(0, 7, -9);
    
	
	void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offSet;
    }
}
