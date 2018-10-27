using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {

	// Use this for initialization

    // Update is called once per frame
    void OnGUI()
    {

        GUI.contentColor = Color.yellow;

        GUIStyle bb = new GUIStyle();
       
      
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 90, 120, 50), "Audio"))
        {
            Application.LoadLevel(4);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 150, 120, 50), "Normal"))
        {
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 210, 120, 50), "Quit"))
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }

    }
}
