using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeThisObjectFly : MonoBehaviour {
    public float movementSpeed = 30.0f;
    public float rotateBy = 10.0f;

	// Use this for initialization
	void Start () {
        Debug.Log("MakeThisObjectFly script reached!");
	}
	
	// Update is called once per frame
	void Update () {
        //next two lines move plane forward and back 
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += transform.forward * (movementSpeed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += transform.forward * (-1 * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.I))
        {
            gameObject.transform.Rotate(Vector3.right, (rotateBy * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.K))
        {
            gameObject.transform.Rotate(Vector3.right, (-1 * rotateBy * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.J))
        {
            gameObject.transform.Rotate(Vector3.forward, (rotateBy * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.L))
        {
            gameObject.transform.Rotate(Vector3.forward, (-1 * rotateBy * Time.deltaTime));
        }  
    }
}
