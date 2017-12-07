using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Username : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //add eventListener that changes when playerName changes
        AskName askName = FindObjectOfType<AskName>();
        Text textBox = GetComponent<Text>();
        textBox.text = askName.playerName;
        
    }
}
