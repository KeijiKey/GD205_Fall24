using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingApplesYeah : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
	GetComponent<Animator>().SetFloat("forward", 2f);
		if (Input.GetKey(KeyCode.LeftShift)){
	GetComponent<Animator>().SetFloat("forward", 4f);
}

	}
else {
	GetComponent<Animator>().SetFloat("forward", 0f);
}

    }
}
