using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeThisObjectFly : MonoBehaviour {
    public float yawAngleRot = 2.5f;
    public float velocityBeforePlaneCanPitchRoll = 30.0f;
    public float maxVelocity = 400.0f;
    public float minVelocity = 25.0f;

    const float THRUST_POWER = 0.75f;
    const float DECCELERATION_POWER = 0.98f;
    const float GRAVITY = 10.0f;
    public float planeVelocity = 0.0f;
    bool isObjectFlying = false;
    //bool hasObjectStalled = false;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
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

        if (planeVelocity >= velocityBeforePlaneCanPitchRoll)
        {
            gameObject.transform.Rotate(Input.GetAxis("Pitch"), 0.0f, -Input.GetAxis("Roll"));
            if(!isObjectFlying)
            {
                isObjectFlying = true;
            }
        }

        planeVelocity -= transform.forward.y * Time.deltaTime * GRAVITY;

        if (isObjectFlying && planeVelocity < velocityBeforePlaneCanPitchRoll)
        {
            planeVelocity = minVelocity;
            //hasObjectStalled = true;
        }

        //if (hasObjectStalled)
        //{

        //}
        gameObject.transform.position += transform.forward * (planeVelocity * Time.deltaTime);
    }
}
