using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	public string id;
	Actor actor;
	public string characterName;
	public int level;
	public int healthCap;
	public Actor.Gender gender;
	private List<CombatAbility> combatMoveSet;
	void Start () {

		combatMoveSet = new List<CombatAbility> ();
		combatMoveSet.Add (new CombatAbilityBasic());
		actor = new EnemyActorFactory ().CreateActor (combatMoveSet, characterName, level, healthCap, gender, id);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D() {
		BattleManager battleManager = GameObject.Find ("Combat System").GetComponent<BattleManager> ();//I may need to change this, relying on this object to exist may be sloppy and I won't likely want more than one instance to be called
		battleManager.StartBattle (actor);
	}
}
