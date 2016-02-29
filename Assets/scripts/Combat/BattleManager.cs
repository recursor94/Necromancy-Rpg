/* * Script which handles battle logic--initiating a UI and state machine object * Should be triggered by collision or detection by enemy units */ using UnityEngine; using System.Collections;
using UnityEngine.UI;

 public class BattleManager : MonoBehaviour { 
	BattleStateMachine battleStateMachine;
	BattleCalculator battleCalculator;
	BattleUI ui;
	Actor enemy; //for test purposes only
	Actor player;

	public static CombatAbility AbilityChosen = null;
	void Awake() {

		//GetComponent <BattleManager>().enabled = false;
	}
	void Start () {
		player = PlayerScript.Player; //setting this to player static actor for convenience.
		battleStateMachine = new BattleStateMachine ();
		//Scrollbar attackChooser = GameObject.Find ("Attack Picker").GetComponent<Scrollbar> (); 
		Camera battleCamera = GameObject.Find ("Battle Camera").GetComponent<Camera> ();
		Debug.Log ("Playerscript.player: " + PlayerScript.Player.Health);
	ui = new BattleUI (player, battleCamera);
//		StartBattle ();
	}
	
	void Update () {

		//Debug.Log(battleStateMachine.CurrentBattleState);
		ChooseStateCallBack ();
	}

	public void StartBattle(Actor enemy) {

		this.enemy = enemy;
		Debug.Log (enemy.ToString ());
		battleStateMachine.StartBattle ();

	}

	private void ChooseStateCallBack() {
		switch(battleStateMachine.CurrentBattleState) {
		case BattleStateMachine.BattleStates.START:
			InitBattle ();
			battleStateMachine.goNextState ();
			break;
		case BattleStateMachine.BattleStates.PLAYERTURN:
			//Player goes first by default, may make this more complicated
			//by determining first turn through role
			PlayerTurn ();
			break;
		case BattleStateMachine.BattleStates.ENDPLAYERTURN:
			PostPlayerTurn ();
			battleStateMachine.goNextState (); //may present a problem if the game ends, but will probably be ignored--something to keep in mind.
			break;
		
		case BattleStateMachine.BattleStates.ENEMYTURN:
			EnemyTurn ();
			battleStateMachine.goNextState ();
			break;
		case BattleStateMachine.BattleStates.ENDENEMYTURN:
			PostEnemyTurn ();
			battleStateMachine.goNextState ();
			break;
		case BattleStateMachine.BattleStates.END:
			PostBattleEffects ();
			battleStateMachine.turnOff ();
			break;
		}
	
	}
	private void PlayerTurn() {
		ui.enableAttackUI ();
		if(AbilityChosen!= null) {
			battleCalculator.applyDamage (enemy, AbilityChosen);
			ui.writeBattleAlert ("Hit " + enemy.Id + "For " + AbilityChosen.BaseDamage);
			Debug.Log("Hit " + enemy.Id + "For " + AbilityChosen.BaseDamage);
			AbilityChosen = null;
			battleStateMachine.goNextState ();
		}
		
	}

	private void InitBattle() {
		Debug.Log("initializing Battle Code.  Should only be called once!");
	
		battleCalculator = new BattleCalculator ();
		ui.setActive (GameObject.Find ("Main Camera").GetComponent<Camera> ());
	}
	private void EnemyTurn() {
		battleCalculator.applyDamage (player, new CombatAbilityBasic());
	}

	private void PostPlayerTurn() {
		/*
		 * Handles events that happen after player turn is over
		 * such as dot effects on player
		 */
		PostTurnEffects ();
	}
	private void PostEnemyTurn() {

		/*
		 * Handles events that happen after enemy turn is over
		 * such as dot effects on enemy
		 */

		ui.disableAttackUI ();
		PostTurnEffects ();
	}

	private void PostTurnEffects() {
		/* Defines behavior that occurs
		 * at the end of each turn, 
		 * both for an end of the player turn, and the end of the 
		 * enemy turn.  EG. Checking if there is a winner.
		 */
		Actor winner = GetWinner ();

		if(winner != null) {

			Debug.Log (winner + " has won!");
			battleStateMachine.EndBattle ();
		}

	}

	private void PostBattleEffects() {
		/*Executes behavior that occurs
		 * at the end of the battle,
		 * such as granting the players rewards
		 */
		ui.setInactive (GameObject.Find ("Main Camera").GetComponent <Camera> ());

		 
	}
	private Actor GetWinner() {
		return battleCalculator.getWinner (player, enemy);
	}
//	public void OnGUI() {
//		if(battleStateMachine.CurrentBattleState == BattleStateMachine.BattleStates.PLAYERTURN) {
//			foreach(var ability in player.CombatMoveSet) {
//				if( GUILayout.Button (ability.Name)) {
//					battleCalculator.applyDamage (enemy, ability);
//					battleStateMachine.goNextState ();
//				}
//			}
//
//		}
//		GUILayout.Label ("Player Health: " + player.Health );
//		GUILayout.Label ("Enemy Health: " + enemy.Health);
//	}
} 