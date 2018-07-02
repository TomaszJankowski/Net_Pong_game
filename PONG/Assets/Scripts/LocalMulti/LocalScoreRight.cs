using UnityEngine;
using UnityEngine.UI;

public class LocalScoreRight : MonoBehaviour {

    public Text text;
    public GameObject ball;

    [HideInInspector]
    public int PlayerLeft = 0;
    [HideInInspector]
    public int PlayerRight = 0;


    private void FixedUpdate()
    {
        text.text = PlayerRight.ToString() + " | " + PlayerLeft.ToString();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        ball = GameObject.Find("Ball");

        if (col.gameObject == ball)
        {
            PlayerLeft++;
        }


    }
}
