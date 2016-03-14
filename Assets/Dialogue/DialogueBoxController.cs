using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBoxController {

    private static volatile DialogueBoxController _instance;
    private static object _syncRoot = new object();

    private float _scrollSpeed; //represents how quickly the text scrolls
    private string[] _lines;  //text lines to be fed to dialogue box
    private Text dialogueTextUI;
    private MonoBehaviour _script;

    private enum WritingState {
        InActive,
        writingLine,
        FinishedLine,
        FinishedAll

    }
    private WritingState _currentState;
	
   private DialogueBoxController() {
        this.ScrollSpeed = .1f;
        this.CurrentState = WritingState.InActive;
        dialogueTextUI = GameObject.Find("DialogueText").GetComponent<Text>();
        _script = new MonoBehaviour();

    }
   
    public static DialogueBoxController Instance {

        get {
            if(_instance == null) {
                lock(_syncRoot) {
                    if(_instance == null) {
                        _instance = new DialogueBoxController();
                    }
                } 
            }
            return _instance;
        }
    }

    public float ScrollSpeed {
        get {
            return _scrollSpeed;
        }

        set {
            _scrollSpeed = value;
        }
    }

    private WritingState CurrentState {
        get {
            return _currentState;
        }

        set {
            _currentState = value;
        }
    }

    private void WriteCharacter(char c) {
        dialogueTextUI.text += "" + c;
    }

    private IEnumerator WriteLine(string line) {
       foreach(char c in line) {
            WriteCharacter(c);
            yield return new WaitForSeconds(ScrollSpeed);
        }

    }

    public void WriteContent(string[] lines) {
        foreach(string line in lines) {
            _script.StartCoroutine(WriteLine(line));
        }
    }
}
