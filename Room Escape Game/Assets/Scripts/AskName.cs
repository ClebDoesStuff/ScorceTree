using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AskName : MonoBehaviour {

    InputField getName;
    //Text inputName;
    public string playerName;

    // Use this for initialization
    void Start () {
        getName = this.gameObject.GetComponent<InputField>();
        //inputName = this.transform.GetChild(2).GetComponent<Text>();
        getName.characterLimit = 16;
        DontDestroyOnLoad(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Press ()
    {
        Debug.Log(getName.text);
        //inputName.text = getName.text;
        playerName = getName.text;
        
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
