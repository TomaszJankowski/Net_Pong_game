using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ResetBall : NetworkBehaviour {


    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject == GameObject.Find("Ball"))
        {
            GameObject.Find("Ball").transform.position = new Vector2(1f, 1.5f);
        }

    }

}
