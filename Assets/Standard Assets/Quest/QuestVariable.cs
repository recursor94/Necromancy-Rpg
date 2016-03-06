using UnityEngine;
using System.Collections;
/* represents quest variable 
*/
public class QuestVariable <T>  {
    private string varName;
    private T value;



    public QuestVariable(string varName, T value) {
        this.varName = varName;
        this.value = value;
    }
    public T Value {
        get {
            return value;
        }

        set {
            this.value = value;
        }
    }
}
