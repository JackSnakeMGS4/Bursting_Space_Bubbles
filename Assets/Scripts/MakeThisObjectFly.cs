using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeThisObjectFly : MonoBehaviour {
    public float pitchAngleRot = 10.0f;
    public float rollAngleRot = 5.0f;
    public float yawAngleRot = 2.5f;
    public float velocityBeforePlaneCanPitchRoll = 30.0f;
    public float maxVelocity = 400.0f;

    const float THRUST_POWER = 0.75f;
    const float DECCELERATION_POWER = 0.98f;
    public float planeVelocity = 0.0f;

    // Use this for initialization
    void Start () {
        Debug.Log("MakeThisObjectFly script reached!");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        if (Input.GetKey(KeyCode.W) && planeVelocity <= maxVelocity)
        {
            planeVelocity += THRUST_POWER;
        }
        else if (Input.GetKey(KeyCode.S) && planeVelocity > 0)
        {
            planeVelocity *= DECCELERATION_POWER;        
        }
        if (Input.GetKey(KeyCode.A) && planeVelocity > 8)
        {
            gameObject.transform.Rotate(Vector3.up, (-1 * yawAngleRot * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D) && planeVelocity > 8)
        {
            gameObject.transform.Rotate(Vector3.up, (yawAngleRot * Time.deltaTime));
        }


        if (planeVelocity > velocityBeforePlaneCanPitchRoll)
        {
            if (Input.GetKey(KeyCode.I))
            {
                gameObject.transform.Rotate(Vector3.right, (pitchAngleRot * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.K))
            {
                gameObject.transform.Rotate(Vector3.right, (-1 * pitchAngleRot * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.J))
            {
                gameObject.transform.Rotate(Vector3.forward, (rollAngleRot * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.L))
            {
                gameObject.transform.Rotate(Vector3.forward, (-1 * rollAngleRot * Time.deltaTime));
            }
        }

        gameObject.transform.position += transform.forward * (planeVelocity * Time.deltaTime);
    }
}
