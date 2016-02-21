﻿/* * Script which handles battle logic--initiating a UI and state machine object * Should be triggered by collision or detection by enemy units */ using UnityEngine; using System.Collections; public class BattleManager : MonoBehaviour { 
	BattleStateMachine battleStateMachine;
	BattleCalculator battleCalculator;
	Actor Enemy; //for test purposes only
	void Awake() {
		
	}
	void Start () {
		battleStateMachine = new BattleStateMachine ();
		Enemy = new TESTEnemyActor ();
		StartBattle (null, null);
	}
	
	void Update () {

		Debug.Log(battleStateMachine.CurrentBattleState);
		ChooseStateCallBack ();
	}

	public void StartBattle(Actor initiator, Actor target) {

		battleStateMachine.StartBattle ();
		Debug.Log (battleStateMachine.CurrentBattleState);

	}

	public void ChooseStateCallBack() {
		switch(battleStateMachine.CurrentBattleState) {
		case BattleStateMachine.BattleStates.START:
			initBattle ();
			battleStateMachine.goNextState ();
			break;
		case BattleStateMachine.BattleStates.PLAYERTURN:
			//Player goes first by default, may make this more complicated
			//by determining first turn through role

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
		}
	}

	public void initBattle() {
		Debug.Log("initializing Battle Code.  Should only be called once!");
	
		battleCalculator = new BattleCalculator ();
	}
	public void EnemyTurn() {
		battleCalculator.applyDamage (PlayerInformation.PlayerActor, new CombatAbilityBasic());
	}

	public void PostPlayerTurn() {
		/*
		 * Handles events that happen after player turn is over
		 * such as dot effects on player
		 */
		PostTurnEffects ();
	}
	public void PostEnemyTurn() {

		/*
		 * Handles events that happen after enemy turn is over
		 * such as dot effects on enemy
		 */
		PostTurnEffects ();
	}

	public void PostTurnEffects() {
		/* Defines behavior that occurs
		 * at the end of each turn, 
		 * both for an end of the player turn, and the end of the 
		 * enemy turn.  EG. Checking if there is a winner.
		 */
		Actor winner = getWinner ();

		if(winner != null) {

			Debug.Log (winner + " has won!");
			battleStateMachine.EndBattle ();
		}

	}

	public Actor getWinner() {
		return battleCalculator.getWinner (PlayerInformation.PlayerActor, Enemy);
	}
	public void OnGUI() {
		if(battleStateMachine.CurrentBattleState == BattleStateMachine.BattleStates.PLAYERTURN) {
			foreach(var ability in PlayerInformation.PlayerActor.CombatMoveSet.Values) {
				if( GUILayout.Button (ability.Name)) {
					battleCalculator.applyDamage (Enemy, ability);
					battleStateMachine.goNextState ();
				}
			}

		}
		GUILayout.Label ("Player Health: " + PlayerInformation.PlayerActor.Health);
		GUILayout.Label ("Enemy Health: " + Enemy.Health);
	}
} 