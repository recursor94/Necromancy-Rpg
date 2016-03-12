using UnityEngine;
using System.Collections;
using NLua;

public class TestLua : MonoBehaviour {
    Lua luaState;
	// Use this for initialization
	void Awake () {
        luaState = new Lua();
        luaState["x"] = 3;

        Debug.Log(luaState["x"]);

        luaState.DoFile("Assets/luascripts/test.lua");
        
        Debug.Log(luaState["b"]);
        LuaManager.Instance.LoadScript("Assets/Lua Scripts/global.lua");
        LuaManager.Instance.LoadScript("Assets/Lua Scripts/QuestScripts.lua");
        LuaManager.Instance.RunChunk("test()");
        //LuaManager.Instance.RunChunk("questsLoaded()");
        LuaManager.Instance.LoadScript("Assets/Lua Scripts/TutorialQuest.lua");
	
	}
	
	// Update is called once per frame
	void Update () {
       
	
	}
}
