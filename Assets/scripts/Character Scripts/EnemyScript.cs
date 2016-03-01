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
	public int baseXp;
	public Actor.Gender gender;
	private List<CombatAbility> combatMoveSet;

	void Start () {

		combatMoveSet = new List<CombatAbility> ();
		combatMoveSet.Add (new CombatAbilityBasic());
		actor = new EnemyActorFactory ().CreateEnemyActor (combatMoveSet, characterName, level, healthCap, gender, id, baseXp);
	}
	
	// Update is called once per frame
	void Update () {
		if(actor.Health <= 0) {
			DeathEvent deathEvent = new DeathEvent (actor);
			QuestEventHandler.sendQuestEvent (deathEvent);
			Destroy (gameObject);
		}
	
	}
	void FixedUpdate() {
		
	}

	void OnTriggerEnter2D() {
		BattleManager battleManager = GameObject.Find ("Combat System").GetComponent<BattleManager> ();//I may need to change this, relying on this object to exist may be sloppy and I won't likely want more than one instance to be called
		battleManager.StartBattle (actor);
	}
}
