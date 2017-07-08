using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {


    public float speed = 4.0f;
	
	// Update is called once per frame
	void Update () {


       // transform.position += Vector3.back * Time.deltaTime * speed;
       // Mathf.Repeat(-Time.time, transform.localScale.z);

        //transform.position = new Vector3(Mathf.Repeat(-Time.time, transform.localScale.z), transform.position.y, transform.position.z);
 
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Repeat(-Time.time * speed, transform.localScale.z));


    }
}
