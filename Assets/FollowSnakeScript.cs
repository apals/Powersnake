using UnityEngine;
using System.Collections;

public class FollowSnakeScript : MonoBehaviour {

	public Transform snakeTransform;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position.Set (snakeTransform.position.x, snakeTransform.position.y, 0);
		int DistanceAway = 10;
		/*this.transform.position = new Vector3(snakeTransform.position.x, 
		                                                               snakeTransform.position.y, 
		                                                               snakeTransform.position.z - DistanceAway);
		                                                               */
	}
}
