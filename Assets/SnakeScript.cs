using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SnakeScript : MonoBehaviour {
	// Current Movement Direction
	// (by default it moves to the right)
	private Vector2 dir = Vector2.right;
	private float turnSpeed = 2f;
	public GameObject snakeTrailPrefab;
	
	// Use this for initialization
	void Start () {
		// Move the Snake every 300ms
		//InvokeRepeating("Move", 0.3f, 0.3f); 
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.forward * -turnSpeed);
		 else if(Input.GetKey(KeyCode.LeftArrow)) 
			transform.Rotate(Vector3.forward * turnSpeed);
		
		Move ();
	}
	
	void Move() {
		// Move head into new direction
		transform.Translate(dir);
		Instantiate (snakeTrailPrefab, this.transform.position, this.transform.rotation);

	}
}