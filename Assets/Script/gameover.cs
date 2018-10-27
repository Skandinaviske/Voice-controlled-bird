using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnGUI () {

        GUI.contentColor = Color.blue;
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 150, 100, 40), "Retry?")) {
            Application.LoadLevel(0);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 200, 100, 40), "Quit"))
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }

    }
}
