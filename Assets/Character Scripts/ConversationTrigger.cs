using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConversationTrigger : MonoBehaviour {

    

	void OnTriggerEnter2D(Collider2D otherObject) {

		//DialogueController.UICanvas.SetActive (true);
//		Actor actor = new TutorialQuestGiverActor();
//		Debug.Log (actor.Id);
//		Debug.Log (DialogueController.getValidConversation(actor.Id).DialogueText);
//		Canvas dialogueCanvas = GameObject.Find ("DialogueCanvas").GetComponent<Canvas> ();
//		dialogueCanvas.gameObject.SetActive (true);
//		Text dialogueBox = GameObject.Find ("DialogueText").GetComponent<Text> ();
//		dialogueBox.text = DialogueController.getValidConversation (Npc.Actor.Id).DialogueText;


	}
	void OnTriggerExit2D(Collider2D otherObject) {
		//DialogueController.UICanvas.SetActive (false);
	}
}
