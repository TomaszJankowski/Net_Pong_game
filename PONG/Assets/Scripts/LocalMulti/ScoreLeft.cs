using UnityEngine;

public class ScoreLeft : MonoBehaviour {

    public GameObject ball;

   public LocalScoreRight Player;

    private void OnCollisionEnter2D(Collision2D col)
    {

        ball = GameObject.Find("Ball");

        if (col.gameObject == ball)
        {
            Player.PlayerRight++;
        }

    }

}
