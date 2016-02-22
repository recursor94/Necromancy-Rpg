using UnityEngine;
using System.Collections;

public class ConversationTrigger : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D otherObject) {


		Actor actor = Npc.Actor;
		Debug.Log (DialogueController.getValidConversation (actor.Id));

	}
}
