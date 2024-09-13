using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPieces : MonoBehaviour
//
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //transform.position += new Vector3(1f,0f,0f);
	 if (Input.GetKeyDown(KeyCode.A)) {
	 transform.position += Vector3.left;
	}

	if (Input.GetKeyDown(KeyCode.D)) {
	 transform.position += Vector3.right;
	}

	if (Input.GetKeyDown(KeyCode.S)) {
	 transform.position += Vector3.back;
	}

	if (Input.GetKeyDown(KeyCode.W)) {
	 transform.position += Vector3.forward;
	}

	if(transform.position == newVector3(0f, 1f, 2f)){
	}
	Debug.Log("Game Over");
    }
}
