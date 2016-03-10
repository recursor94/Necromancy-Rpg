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

        luaState.DoFile("Assets/Standard Assets/luascripts/test.lua");
        
        Debug.Log(luaState["b"]);
        LuaManager.Instance.LoadScript("Assets/Standard Assets/Lua Scripts/global.lua");
        LuaManager.Instance.RunChunk("test()");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
