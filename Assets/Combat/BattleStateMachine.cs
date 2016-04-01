using UnityEngine;
using System.Collections;

public class BattleStateMachine  {

	public enum BattleStates {
		OFF,
		START,
		PLAYERTURN,
		ENDPLAYERTURN,
		ENEMYTURN,
		ENDENEMYTURN,
		END
	}
	private BattleStates currentBattleState;

	public BattleStateMachine() {

		currentBattleState = BattleStates.OFF;

	}




	public BattleStates CurrentBattleState{ get { return currentBattleState; } }

	public void goNextState() {
		//Should loop from player turn to enemy turn and back
		//ending should only be done when fight has been one or lost, 
		//defined in different method
		switch(currentBattleState) {
		case BattleStates.START:
			currentBattleState = BattleStates.PLAYERTURN;
			break;

		case BattleStates.PLAYERTURN:
			currentBattleState = BattleStates.ENDPLAYERTURN;
			break;
		case BattleStates.ENDPLAYERTURN:
			currentBattleState = BattleStates.ENEMYTURN;
			break;
		case BattleStates.ENEMYTURN:
			currentBattleState = BattleStates.ENDENEMYTURN;
			break;
		case BattleStates.ENDENEMYTURN:
			currentBattleState = BattleStates.PLAYERTURN;
			break;
		}
	}

	public void EndBattle() {
		/*
		 * sets state machine to the end state
		 * Should be triggered after one player has 
		 * forfeited or won/lost
		 */
		currentBattleState = BattleStates.END;
	}
	public void StartBattle() {
		/*
		 * initiates the battle state machine,
		 * should be called from the off state.
		 */
		currentBattleState = BattleStates.START;
	}
	public void turnOff() {
		/*
		 * executed at the end of the battle,
		 * turns the state machine off.
		 */
		currentBattleState = BattleStates.OFF;
	}


}
