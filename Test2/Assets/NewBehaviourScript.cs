using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    public float speed = 0.001F;
    public float rotationSpeed = 100.0F;
    void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + x * speed, -1.0f, transform.position.z + z * speed);

        Debug.Log("aaa:" + x + ":" + z);
    }

}
