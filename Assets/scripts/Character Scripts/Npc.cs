using UnityEngine;
using System.Collections;

public class Npc : MonoBehaviour {

	// Use this for initialization
	//class for representing this npcs data--including attached actor
	public static Actor Actor; //actor that npc is associated with
	void Start () {
		Actor = new TutorialQuestGiverActor ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
