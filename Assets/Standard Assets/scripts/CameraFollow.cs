using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


	public Transform Target;
	public float mSpeed;
	private Camera mCamera;
	float cameraZ; //original camera z position, to prevent it from zooming in on map on update
	// Use this for initialization
	void Start () {
		mCamera = GetComponent<Camera> ();
		cameraZ = mCamera.transform.position.z; //so that the camera's position doesn't zoom into map
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		mCamera.orthographicSize = (Screen.height / 100f) / 4f;

		if (Target) {
			transform.position = Vector3.Lerp (transform.position, Target.position, mSpeed) + new Vector3(0,0, cameraZ);
		}
	}

	public void SetPositionToTarget() {
		/*sets the camera directly at the target's position.
		 */
		if(Target) {
			transform.position =  Target.transform.position + new Vector3(0,0, cameraZ);

		}

	}
}
