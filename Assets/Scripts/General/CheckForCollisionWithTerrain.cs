using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCollisionWithTerrain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float heightOfTerrainHere = Terrain.activeTerrain.SampleHeight(gameObject.transform.position);

        if (heightOfTerrainHere > gameObject.transform.position.y)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, heightOfTerrainHere, gameObject.transform.position.z);
        }
	}
}
