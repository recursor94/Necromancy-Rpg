/* * Script which handles battle logic--initiating a UI and state machine object * Should be triggered by collision or detection by enemy units */ using UnityEngine; using System.Collections; public class BattleManager : MonoBehaviour { 
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
		battleStateMachine.CurrentBattleState = BattleStateMachine.BattleStates.START;
		Debug.Log (battleStateMachine.CurrentBattleState);
	}

	public void ChooseStateCallBack() {
		switch(battleStateMachine.CurrentBattleState) {
		case BattleStateMachine.BattleStates.START:
			initBattle ();
			break;
		case BattleStateMachine.BattleStates.PLAYERTURN:
			//Player goes first by default, may make this more complicated
			//by determining first turn through role
			break;
		case BattleStateMachine.BattleStates.ENEMYTURN:
			enemyTurn ();
			break;
			

		}
	}

	public void initBattle() {
		Debug.Log("initializing Battle Code.  Should only be called once!");
	
		battleCalculator = new BattleCalculator ();
		battleStateMachine.CurrentBattleState = BattleStateMachine.BattleStates.PLAYERTURN;
	}
	public void enemyTurn() {
		battleCalculator.applyDamage (PlayerInformation.PlayerActor, new CombatAbilityBasic());
		battleStateMachine.CurrentBattleState = BattleStateMachine.BattleStates.PLAYERTURN;
	}
	bool 
	public void OnGUI() {
		if(battleStateMachine.CurrentBattleState != BattleStateMachine.BattleStates.OFF && battleStateMachine.CurrentBattleState != BattleStateMachine.BattleStates.END) {
			foreach(var ability in PlayerInformation.PlayerActor.CombatMoveSet.Values) {
				if( GUILayout.Button (ability.Name)) {
					battleCalculator.applyDamage (Enemy, ability);
					battleStateMachine.CurrentBattleState = BattleStateMachine.BattleStates.ENEMYTURN;
				}
			}
			GUILayout.Label ("Player Health: " + PlayerInformation.PlayerActor.Health);
			GUILayout.Label ("Enemy Health: " + Enemy.Health);
		}
		
	}
} 