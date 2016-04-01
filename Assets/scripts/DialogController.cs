using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogController : MonoBehaviour {

	// Use this for initialization
	public Text dialogueText;
	public Button nextLineButton;
	public CanvasRenderer canvas;
	void Start () {
		canvas = GameObject.Find ("DialogueCanvas").GetComponent<CanvasRenderer>();
		dialogueText = GameObject.Find ("DialogueText").GetComponent<Text> ();
		nextLineButton = GameObject.Find ("DialoguePanel").GetComponent<Button> ();
		dialogueText.text = "HOOBLAH!";


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
