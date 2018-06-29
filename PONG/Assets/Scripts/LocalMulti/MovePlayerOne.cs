using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerOne : MonoBehaviour {

    [SerializeField] float MovementSpeed;
    
    void FixedUpdate()
    {

        float updown = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, updown) * MovementSpeed * Time.deltaTime;
    }
}
