using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BallMovment : NetworkBehaviour {

    [SerializeField] float Speed;
    ScoreGUI score;


    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(2);
        CmdStartBall();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Vector2 Pl = new Vector2(0.1f, 1.5f);
        Vector2 Pr = new Vector2(1.85f, 1.5f);
        GameObject PlayerLeft = GameObject.Find("Player(Clone)");
        GameObject PlayerRight = GameObject.Find("Player(Clone)");

        float dist = this.transform.position.y - PlayerLeft.transform.position.y;
        float dist1 = this.transform.position.y - PlayerRight.transform.position.y;


        if (col.gameObject.transform.position.x == Pl.x)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, dist * 4);

        }

        if (col.gameObject.transform.position.x == Pr.x)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-1f, dist1 * 4);
        }

       
    }



    [Command]
    void CmdStartBall()
    {
        
        int ranX = Random.Range(-1, 2);
        int ranY = Random.Range(-1, 2);

        Vector2 v = new Vector2(ranX, ranY) * Speed * Time.deltaTime;
        this.GetComponent<Rigidbody2D>().AddForce(v);


    }
    

}

  
