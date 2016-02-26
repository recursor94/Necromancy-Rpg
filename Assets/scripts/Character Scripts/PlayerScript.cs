using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

	string id;
	public static Actor Player ;//player's actor will be passed as quest participant
	// Use this for initialization
	public static string PlayerId = "player";

	public string characterName;
	public int healthCap;
	public int level;
	public Actor.Gender gender;

	private static List<CombatAbility> combatMoves = new List<CombatAbility>();

	void Start () {
		combatMoves.Add (new CombatAbilityBasic());
		Player =  new PlayerActorFactory ().CreateActor (combatMoves, characterName, level, healthCap, gender, id);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
