using UnityEngine;
using System.Collections;

public class RunKillQuest : MonoBehaviour {

	public  string targetId;
	public  int killCount;
	// Use this for initialization
	private KillQuest quest;
	public string name;
	void Start () {

		quest = new KillQuest (name, PlayerInformation.PlayerActor, targetId);
		Debug.Log ("Starting Kill Quest: " + quest.ToString ());

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
