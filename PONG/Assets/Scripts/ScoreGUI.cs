using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ScoreGUI : NetworkBehaviour {

    public int ScorePlayerRight;
    public int ScorePlayerLeft;
    [SerializeField] GUIStyle style;
    

    private void OnGUI()
    {
        float x = Screen.width / 2f;
        float y = 30f;
        float width = 300f;
        float height = 20f;
        string text = "Prawy Gracz: " + ScorePlayerRight + " | "+ "Lewy Gracz: " + ScorePlayerLeft; 

        GUI.Label(new Rect(x - (width / 2), y, width, height),text,style);
    }

}
