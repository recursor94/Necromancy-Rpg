using UnityEngine;
using System.Collections;

public class BattleCameraScript : MonoBehaviour {

	void Awake() {
		gameObject.GetComponent <Camera> ().enabled = false;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
