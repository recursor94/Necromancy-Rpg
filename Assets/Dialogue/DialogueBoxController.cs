﻿using UnityEngine;
using System.Collections;

public class DialogueBoxController {

    private static volatile DialogueBoxController _instance;
    private static object _syncRoot = new object();

    private double _scrollSpeed; //represents out quickly the text scrolls
    private string[] _lines;  //text lines to be fed to dialogue box
	
   private DialogueBoxController() {
        this.ScrollSpeed = 1f; 
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

    public double ScrollSpeed {
        get {
            return _scrollSpeed;
        }

        set {
            _scrollSpeed = value;
        }
    }
}