using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeThisObjectFly : MonoBehaviour {
    public float rotateBy = 15.0f;

    const float THRUST_POWER = 0.5f;
    const float DECCELERATION_POWER = 0.15f;
    public float planeSpeed = 0.0f;

    // Use this for initialization
    void Start () {
        Debug.Log("MakeThisObjectFly script reached!");
	}
	
	// Update is called once per frame
	void Update () {
        //next two lines move plane forward and back 
        //if (Input.GetKey(KeyCode.W))
        //{
        //    gameObject.transform.position += transform.forward * (movementSpeed * Time.deltaTime); 
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    gameObject.transform.position += transform.forward * (-1 * movementSpeed * Time.deltaTime);
        //}
        if (Input.GetKey(KeyCode.W))
        {
            planeSpeed += THRUST_POWER;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (planeSpeed > 0)
            {
                planeSpeed -= DECCELERATION_POWER;
            }          
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
        Debug.Log(gameObject.transform.rotation);

        gameObject.transform.position += transform.forward * (planeSpeed * Time.deltaTime);
    }
}
