using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

	public Transform warpTarget;

	void OnTriggerEnter2D(Collider2D other) {

		//other.transform.position = warpTarget.position;
        LuaManager.Instance.CallFunction("teleport", other.transform, warpTarget.transform);
		//set camera directly to player position rather than moving there slightly
        //but only do so if the trigger is the player
        if(other.gameObject.Equals(GameObject.Find("Player"))) {
    		CameraFollow cameraScript = GameObject.Find ("Main Camera").GetComponent<CameraFollow> ();
    		cameraScript.SetPositionToTarget (); 


        }
        

	}

}
