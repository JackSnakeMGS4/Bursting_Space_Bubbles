using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeColor : MonoBehaviour {
    public Material[] randomizeFromThisCollection;
    private MeshRenderer bubble;

	// Use this for initialization
	void Start () {
        bubble = GetComponent<MeshRenderer>();
        bubble.material = randomizeFromThisCollection[Random.Range(0, randomizeFromThisCollection.Length - 1)];
    }
}
