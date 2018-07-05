using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBubbles : MonoBehaviour {
    public GameObject bubbleToShoot;
    public Transform[] positionsToShootFrom;
    public float bubbleVelocity = 10.0f;
    public float delayBeforeBubblePops = 10.0f;

    private void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetButton("Fire1"))
        {
            for(int i = 0; i < positionsToShootFrom.Length; i++)
            {
                GameObject bubbleInstance = Instantiate(bubbleToShoot, positionsToShootFrom[i]);
                Rigidbody rb = bubbleInstance.GetComponent<Rigidbody>();
                rb.AddForce(bubbleInstance.transform.forward * bubbleVelocity * Time.deltaTime, ForceMode.Impulse);
                Debug.Log("Destroying: " + bubbleInstance + " in " + delayBeforeBubblePops + " seconds");
                Destroy(bubbleInstance, delayBeforeBubblePops);
            }
        }
    }
}
