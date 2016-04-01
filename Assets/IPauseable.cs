using UnityEngine;
using System.Collections;

/*
* interface for pauseable game scripts--eg player movement
*/

public interface IPauseable {

    void OnPause();
    void OnResume();
}
