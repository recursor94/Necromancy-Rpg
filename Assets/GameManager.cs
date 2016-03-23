using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager Instance; 
	// Use this for initialization
    void Awake() {
        DontDestroyOnLoad(gameObject);
        Instance = this;

    }

	void Start () {
	
	}
    void OnEnable() {
        Instance = this;
    }
    // Update is called once per frame
    void Update () {
	
	}
    public void pause() {
        MonoBehaviour [] scripts = GameObject.FindObjectsOfType(typeof(MonoBehaviour)) as MonoBehaviour[];
        foreach (MonoBehaviour script in scripts) {
            if(script is IPauseable) {
                IPauseable pauseableScript = (IPauseable)script;
                pauseableScript.OnPause();
            }
        }
    }
}
