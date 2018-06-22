using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;



public enum ePlayer
{
  [SyncVar]
   Right,
   Left
}
public class Move : NetworkBehaviour {


    [SerializeField] float MovementSpeed;

	// Use this for initialization
	void Start () {

        if (!isLocalPlayer)
        {
            Destroy(this);
            return;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        float updown = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, updown)*MovementSpeed*Time.deltaTime;
	}
}
