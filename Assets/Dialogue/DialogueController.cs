using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour {

	public static List<Conversation> ActiveConversations = new List<Conversation>();
	public static GameObject UICanvas;
	// Use this for initialization
	void Awake () {
		UICanvas = GameObject.Find ("DialogueCanvas");
		UICanvas.SetActive (false);
	}
	void Start () {
		Canvas canvas = UICanvas.GetComponent <Canvas> ();
		Camera camera = GameObject.Find ("Main Camera").GetComponent<Camera> ();
		//Rect rect = canvas.pixelRect;
		//rect.width = camera.pixelWidth;
		


	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void AddActiveConversation(Conversation c) {
	
		ActiveConversations.Add (c);
	}

	public static Conversation getValidConversation(string guid) {
		/*
		 * returns the first valid conversation for the npc
		 * may make this based on a priority system later,
		 * but there should not be more than one valid conversation for an npc 
		 * at any given time for now
		 */

		foreach(Conversation conversation in ActiveConversations) {

			if(conversation.isNpcValid (guid)) {
				return conversation;
			}
		}
		return null;
	}
}
