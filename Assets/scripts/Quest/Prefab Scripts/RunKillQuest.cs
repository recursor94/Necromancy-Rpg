using UnityEngine;
using System.Collections;

public class RunKillQuest : MonoBehaviour {

	public  string targetId;
	public  int killCount;
	// Use this for initialization
	private KillQuest quest;
	void Start () {

		quest = new KillQuest (PlayerInformation.PlayerActor, targetId);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
