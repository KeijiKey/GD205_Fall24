using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPieces : MonoBehaviour
{
public Transform MrX;
Vector3 startPos;
//

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       //transform.position += new Vector3(0f,0f,0f);
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
    }
}
