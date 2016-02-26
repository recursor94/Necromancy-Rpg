using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

	public Transform warpTarget;

	void OnTriggerEnter2D(Collider2D other) {

		other.transform.position = warpTarget.position;
		//set camera directly to player position rather than moving there slightly
		CameraFollow cameraScript = GameObject.Find ("Main Camera").GetComponent<CameraFollow> ();
		cameraScript.SetPositionToTarget (); 


	}

}
