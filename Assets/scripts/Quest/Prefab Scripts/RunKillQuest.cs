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
	void Start () {

		targetDictionary = new Dictionary<string, int> ();

		for(int i = 0; i < targetIds.Count; i++) {
			targetDictionary.Add (targetIds[i], killCounts[i]);
		}
		quest = new KillQuest (name, PlayerInformation.PlayerActor, targetDictionary);
		Debug.Log ("Starting Kill Quest: " + quest.ToString ());

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
