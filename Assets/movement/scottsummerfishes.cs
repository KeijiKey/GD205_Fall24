using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scottsummerfishes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
	Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
	
	RaycastHit laserImpactReport = new RasycastHit();
	if(Physics.Raycast(laser, out laserImpactReport));
	   Debug.Log("BLASTED THAT WORKS! OH WAIT");
	
    }
}
