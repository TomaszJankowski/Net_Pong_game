using UnityEngine;
using UnityEngine.Networking;

public class ScoreRight : NetworkBehaviour
{
   public GameObject ball;

   public Score Player;
    
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
        Player.PlayerLeft++;
    }
}