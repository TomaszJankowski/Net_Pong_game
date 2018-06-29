using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Multi_BallMovment : NetworkBehaviour {

    [SerializeField] float Speed;

    GameObject[] Player;
    Vector2 pl, pr;
    float ranX, ranY;

    private void Start()
    {
        StartCoroutine(WaitForPlayer(3));
    }

    private void FixedUpdate()
    {
        Player = GameObject.FindGameObjectsWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        pl = Player[0].transform.position;
        pr = Player[1].transform.position;


            float dist = this.transform.position.y - Player[0].transform.position.y;
            float dist1 = this.transform.position.y - Player[1].transform.position.y;

            if (col.gameObject.transform.position.x == pl.x)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, dist * 2);

            }

            if (col.gameObject.transform.position.x == pr.x)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-1f, dist1 * 2);
            }
    }

    IEnumerator WaitForPlayer(float time)
    {
            yield return new WaitForSecondsRealtime(time);
            CmdStartBall();
    }

    [Command]
    void CmdStartBall()
    {
        ranX = Random.Range(0.3f,0.8f);
        ranY = Random.Range(0.3f, 0.8f);

        Vector2 v = new Vector2(ranX, ranY) * Speed * Time.deltaTime;
       
        this.GetComponent<Rigidbody2D>().AddForce(v);
    }


}

  
