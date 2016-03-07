using UnityEngine;
using System.Collections;
using NLua;


/* Follows the singleton pattern to 
*   create one single globally accesed lua environment
*/
public sealed class LuaManager  {
    private static volatile LuaManager _instance; //thread safe and statically initialized
    private static object _syncRoot = new object(); //lock to make thread safe

    //Now for the instance fields
    private Lua _LuaEnvironment; //Actual environment/interpreter for game.  I only want one for the game, so the state of all variables can be accessed by any lua script
	
    private LuaManager() {
        this._LuaEnvironment = new Lua();
    } //Empty default contructor to prevent initialization outside of static

    public static LuaManager Instance {
        get {
            if(_instance == null) {
                lock(_syncRoot) {
                    if (_instance == null)
                        _instance = new LuaManager();
                }
            }
            return _instance;
        }
    }
    //now for the instance methods.  These may not be thread safe and shuld be modified later.
}
