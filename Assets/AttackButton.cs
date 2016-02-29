using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AttackButton : MonoBehaviour {
	private  CombatAbility associatedAbility; //keeps track of ability it refers to so it can update battle manager var with it when clicked.
	void Awake() {
		Debug.Log ("Attack button is awake");
		transform.SetParent (GameObject.Find("Grid").transform);
		transform.localScale = new Vector3 (1, 1, 1);


	}
	// Use this for initialization
	void Start () {
		Button b = gameObject.GetComponent<Button> ();
		b.onClick.AddListener (onButtonClicked);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void onButtonClicked() {

		BattleManager.AbilityChosen = associatedAbility;
		
	}

	public CombatAbility AssociatedAbility {
		get {
			return associatedAbility;
		}
		set {
			associatedAbility = value;
		}
	}
}
