﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float tumble;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.value * tumble;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
