using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RunKillQuest : MonoBehaviour {

	public  string targetId;
	// Use this for initialization
	protected KillQuest quest;
	public string questName;
	public List<string> targetIds;
	public List<int> killCounts;
	public Dictionary<string, int> targetDictionary;
	public List<string> convNpcs;
	public List<string> conversationText;
	protected List<Conversation> conversations;
    protected string questId;
    public string luaScriptName;

	void Start () {

		targetDictionary = new Dictionary<string, int> ();
		conversations = new List<Conversation> ();

		for(int i = 0; i < targetIds.Count; i++) {
			targetDictionary.Add (targetIds[i], killCounts[i]);
		}
		for(int i = 0; i < conversationText.Count; i++) {


			conversations.Add (new Conversation (conversationText [i], convNpcs));
		}
		quest = new KillQuest (questId, questName, PlayerScript.Player, targetDictionary);
		quest.Conversations.AddRange (conversations);
		Debug.Log ("Starting Kill Quest: " + quest.ToString ());
		QuestEventHandler.AddActiveQuest (quest);
        LuaManager.Instance.CallFunction(luaScriptName + ":construct", quest);
	
	}
	
	// Update is called once per frame
	void Update () {
        LuaManager.Instance.RunChunk(luaScriptName + ":onUpdate()");
	}
}
