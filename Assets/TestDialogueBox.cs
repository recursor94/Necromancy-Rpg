using UnityEngine;
using System.Collections;

public class TestDialogueBox : MonoBehaviour {

    public string[] test;
	// Use this for initialization
	void Start () {
        DialogueBoxController.Instance.WriteLines(test);
	}
	
	// Update is called once per frame
	void Update () {
        DialogueBoxController.Instance.interrupt();
	}
}
