using UnityEngine;
using System.Collections;
using NLua;

public class TestLua : MonoBehaviour {
    Lua luaState; 
	// Use this for initialization
	void Start () {
        luaState = new Lua();
        luaState["x"] = 3;

        Debug.Log(luaState["x"]);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
