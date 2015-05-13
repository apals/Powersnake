﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SnakeScript : MonoBehaviour {
	// Current Movement Direction
	// (by default it moves to the right)
	Vector2 dir = Vector2.right;
	
	// Use this for initialization
	void Start () {
		// Move the Snake every 300ms
		InvokeRepeating("Move", 0.3f, 0.3f); 
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.RightArrow))
			dir = Vector2.right;
		else if (Input.GetKey(KeyCode.DownArrow))
			dir = -Vector2.up;    // '-up' means 'down'
		else if (Input.GetKey(KeyCode.LeftArrow))
			dir = -Vector2.right; // '-right' means 'left'
		else if (Input.GetKey(KeyCode.UpArrow))
			dir = Vector2.up;


	}
	
	void Move() {
		// Move head into new direction
		transform.Translate(dir);
	}
}