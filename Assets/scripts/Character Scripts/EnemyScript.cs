using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	public string id;
	Actor actor;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D() {
		BattleManager battleManager = GameObject.Find ("Combat System").GetComponent<BattleManager> ();//I may need to change this, relying on this object to exist may be sloppy and I won't likely want more than one instance to be called
		battleManager.StartBattle (actor);
	}
}
