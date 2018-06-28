using UnityEngine;
using UnityEngine.Networking;




public class Move : NetworkBehaviour {

    [SerializeField] float MovementSpeed;

	void Start () {

        if (!isLocalPlayer)
        {
            Destroy(this);
            return;
        }

    }
	
	void FixedUpdate () {

        float updown = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, updown)*MovementSpeed*Time.deltaTime;
	}
}
