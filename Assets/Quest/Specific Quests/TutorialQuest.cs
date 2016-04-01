using UnityEngine;
using System.Collections;

public class TutorialQuest : RunKillQuest {

	// Use this for initialization
	void Start () {
        //base.Start();
        LuaManager.Instance.CallFunction("TutorialQuest:construct", quest);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
