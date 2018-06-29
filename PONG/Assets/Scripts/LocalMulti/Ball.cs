using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] float Speed;

    public GameObject player1, player2;
    Vector2 pl, pr;
    float ranX, ranY;

     void Start()
    {
        StartCoroutine(WaitForPlayer(2));
    }

    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        pl = player1.transform.position;
        pr = player2.transform.position;


        float dist = this.transform.position.y - player1.transform.position.y;
        float dist1 = this.transform.position.y - player2.transform.position.y;

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
        StartBall();
    }

   
    void StartBall()
    {
        ranX = Random.Range(0.3f, 0.8f);
        ranY = Random.Range(0.3f, 0.8f);

        Vector2 v = new Vector2(ranX, ranY) * Speed * Time.deltaTime;

        this.GetComponent<Rigidbody2D>().AddForce(v);
    }
}
