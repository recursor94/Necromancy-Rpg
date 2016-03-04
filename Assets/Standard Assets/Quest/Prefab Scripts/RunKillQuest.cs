using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RunKillQuest : MonoBehaviour {

	public  string targetId;
	// Use this for initialization
	private KillQuest quest;
	public string name;
	public List<string> targetIds;
	public List<int> killCounts;
	public Dictionary<string, int> targetDictionary;
	public List<string> convNpcs;
	public List<string> conversationText;
	private List<Conversation> conversations;
	private Actor participant;
    public string questId;
	void Start () {

		targetDictionary = new Dictionary<string, int> ();
		conversations = new List<Conversation> ();

		for(int i = 0; i < targetIds.Count; i++) {
			targetDictionary.Add (targetIds[i], killCounts[i]);
		}
		for(int i = 0; i < conversationText.Count; i++) {


			conversations.Add (new Conversation (conversationText [i], convNpcs));
		}
		quest = new KillQuest (questId, name, participant, targetDictionary);
		quest.Conversations.AddRange (conversations);
		Debug.Log ("Starting Kill Quest: " + quest.ToString ());
		QuestEventHandler.AddActiveQuest (quest);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
