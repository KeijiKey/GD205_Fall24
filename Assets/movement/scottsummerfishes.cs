using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scottsummerfishes : MonoBehaviour
{
	public float explosionForce = 1800f;
	public float explosionRadius = 39f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
	Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
	
	RaycastHit laserImpactReport = new RaycastHit();
	
	if (Physics.Raycast(laser, out laserImpactReport)){

	if (Input.GetMouseButtonDown(0)){

		Debug.Log("Pressed left-click.");

		Destroy(laserImpactReport.transform.gameObject);

			Debug.Log("BLASTED THAT WORKS! OH WAIT");
		}

	}
	else if (Input.GetMouseButtonDown(1)){
	laserImpactReport.rigidbody.AddExplosionForce(explosionForce,laserImpactReport.point,explosionRadius);
}

}}
