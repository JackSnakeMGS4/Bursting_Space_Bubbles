﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForBubbleHits : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " hit");
        //Destroy(gameObject);
    }
}