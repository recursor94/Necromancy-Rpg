using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class BattleUI  {


	private Actor player; //references player to determine available menu options

	private List<Button> attackChooser ; //references component to choose which attack to make
	private List<string> attackChoices;
	private Camera battleCamera;
	private Text CombatMessageBox;
	private GameObject abilityGrid;
	public BattleUI(Actor player, Camera battleCamera) {
		this.player = player;
		this.attackChooser = new List<Button>();
		this.attackChoices = new List<string> ();
		this.battleCamera = battleCamera;
		//ScrollRect scrollBarContent = GameObject.Find ("Content").GetComponent <ScrollRect> ();

		Debug.Log (player);
		Debug.Log (player.CombatMoveSet);
		List<CombatAbility> playerAbilities = player.CombatMoveSet;
//
//		foreach(CombatAbility ability in playerAbilities) {
//			attackChoices.Add (ability.Name);
//			Buton choice = .gameObject.AddComponent <Button>();
//			abilityScrollBar.hand
//			abilityScrollBar.gameObject.AddComponent <Button> (choice);

		GameObject prefab = null;
			 prefab = GameObject.Find ("Ability Button");
		foreach(CombatAbility ability in playerAbilities) {

			GameObject attackButton = GameObject.Instantiate (prefab);
			Text buttonText = attackButton.GetComponentInChildren <Text>();
			buttonText.text = ability.Name;
			attackButton.GetComponent<AttackButton> ().AssociatedAbility = ability;

//			attackButton.transform.SetParent (GameObject.Find("Grid").transform);
			//RectTransform abilityPanelTransform = GameObject.Find ("ability panel").GetComponent<RectTransform> ();
		}
		prefab.SetActive (false);
		abilityGrid = GameObject.Find ("Grid");
		CombatMessageBox = GameObject.Find ("Combat Message Box").GetComponent <Text> ();
		CombatMessageBox.enabled = false;
//		}

	



	}

	public void setActive(Camera activeCamera) {
		/*sets the active camera as enabled and sets the battle camera
		 * to UI so that everything is disabled in the player view but the battle scenario.
		 */
		battleCamera.enabled = true;
		activeCamera.enabled = false;
	}

	public void writeBattleAlert(string message) {

		CombatMessageBox.enabled = true;
		CombatMessageBox.text = message; 
		abilityGrid.SetActive (false);

	}
	public void setInactive(Camera inActiveCamera) {

		inActiveCamera.enabled = true;
		battleCamera.enabled = false;
	}
	public void enableAttackUI() {

		/* Re-enable attack ui for player, which is likely disabled when it is not his turn.
		 */
		abilityGrid.SetActive (true);
	}

	public void disableAttackUI() {

		/*Disables the attack selection menu for the player--should be called when it is not his turn.
		 */
		abilityGrid.SetActive (false);
	}



}
