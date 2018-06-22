using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Score : NetworkBehaviour {

    public Text text;
    public GameObject ball;

    
    public int PlayerLeft = 0;
    private int PlayerRight = 0;


    private void FixedUpdate()
    {
        text.text = PlayerRight.ToString() + " | " + PlayerLeft.ToString();

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        ball = GameObject.Find("Ball");

        if (col.gameObject == ball)
        {
            RpcScore();
        }
        

    }

    [ClientRpc]
    void RpcScore()
    {
        PlayerRight++;
        text.text = PlayerRight.ToString() + " | " + PlayerLeft.ToString();
    }

}
