using UnityEngine;
using System.Collections;


/* Follows the singleton pattern to 
*   create one single globally accesed lua environment
*/
public sealed class LuaManager  {
    private static volatile LuaManager instance; //thread safe and statically initialized
    private static object syncRoot = new object(); //lock to make thread safe
	
    private LuaManager() { } //Empty default contructor to prevent initialization outside of static

    public static LuaManager Instance {
        get {
            if(instance == null) {
                lock(syncRoot) {
                    if (instance == null)
                        instance = new LuaManager();
                }
            }
            return instance;
        }
    }
}
