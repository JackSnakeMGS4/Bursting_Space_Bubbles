using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCameraForPlayer : MonoBehaviour {
    public GameObject playerGO;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 camGoTo = playerGO.transform.position - playerGO.transform.forward * 3.0f + Vector3.up * 0.5f;

        Camera.main.transform.position = camGoTo;
        Camera.main.transform.LookAt(playerGO.transform.position);
        //Camera.main.transform.rotation = Quaternion.Slerp(playerGO.transform.rotation, Camera.main.transform.rotation, -2.0f * Time.deltaTime);
    }
}
