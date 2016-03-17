using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBoxController {

    private static volatile DialogueBoxController _instance;
    private static object _syncRoot = new object();

    private float _scrollSpeed; //represents how quickly the text scrolls
    private Text dialogueTextUI;

    private enum WritingState {
        InActive,
        writingLine,
        FinishedLine,
        FinishedAll,
        Interrupted

    }
    private WritingState _currentState;
	
   private DialogueBoxController() {
        this.ScrollSpeed = .05f;
        this.CurrentState = WritingState.InActive;
        dialogueTextUI = GameObject.Find("DialogueText").GetComponent<Text>();

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

   
    private void WriteWholeLine(string line) {
        dialogueTextUI.text += line; //write out whole line to dialogue UI rather than character by character

    }

    private IEnumerator WriteContent(string[] lines) {
        foreach(string line in lines) {
            Debug.Log("Line: " +  line);
            //GameManager.Instance.StartCoroutine(WriteLine(line));
            int index = 0; //keep track of index in case interrupted
            foreach(char c in line) {
                if(CurrentState == WritingState.Interrupted) {
                    string output = line.Substring(index + 1); //If the scrolling was interrupted (eg by player hitting next before line finished scrolling)  stop scrolling and output the rest of the contents of the line immediately
                    WriteWholeLine(line);
                    CurrentState = WritingState.FinishedLine;
                    break;
                }
                WriteCharacter(c);
                index++;
                yield return new WaitForSeconds(ScrollSpeed);
            }
        }
    }
    public void WriteLines(string [] lines) {
        GameManager.Instance.StartCoroutine(WriteContent(lines));

    }

    public void interrupt() {
        /*
        Interrupt dialogue scrolling by setting current state to interrupted
        */
        CurrentState = WritingState.Interrupted;
    }
}
