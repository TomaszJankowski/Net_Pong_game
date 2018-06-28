using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class BallMovment : NetworkBehaviour {

    [SerializeField] float Speed;

    IEnumerator Start()
    {
        if (!isLocalPlayer)
        {
            Destroy(this);
        }
        yield return new WaitForSecondsRealtime(2);
            CmdStartBall();
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        
        GameObject[] Player = GameObject.FindGameObjectsWithTag("Player");

        Vector2 Pl = new Vector2(0.1f, 1.5f);
        Vector2 Pr = new Vector2(1.85f, 1.5f);

        float dist = this.transform.position.y - Player[0].transform.position.y;
        float dist1 = this.transform.position.y - Player[1].transform.position.y;


        if (col.gameObject.transform.position.x == Pl.x)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, dist * 2);

        }

        if (col.gameObject.transform.position.x == Pr.x)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-1f, dist1 * 2);
        }
    }

    [Command]
    void CmdStartBall()
    {
        float ranX = Random.Range(-0.8f,0.8f);
        float ranY = Random.Range(-0.8f, 0.8f);

        Vector2 v = new Vector2(ranX, ranY) * Speed * Time.deltaTime;
        this.GetComponent<Rigidbody2D>().AddForce(v);
    }
    

}

  
