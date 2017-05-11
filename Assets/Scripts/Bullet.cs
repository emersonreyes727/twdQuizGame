﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	private float force = 100f;
	private Vector3 resetPosition = new Vector3 (0, -5, 0);
	private float distance = 20f;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		// if the bullet is far away from the resetposition
		// just let the bullet fly away
		// don't let the gameobjects to stop the bullet
		if (Vector3.Distance (transform.position, resetPosition) > distance) {
			transform.position = resetPosition;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// the force applied to the bullet
		// use time.deltatime
		rb.AddForce (transform.forward * (force * Time.deltaTime), ForceMode.Impulse);
	}
}
