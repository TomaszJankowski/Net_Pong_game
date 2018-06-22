using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratio : MonoBehaviour {
    public bool maintainWidth = true;

    float defaultWidth;
    


    // Use this for initialization
    void Start () {

      

        defaultWidth = this.GetComponent<Camera>().orthographicSize * this.GetComponent<Camera>().aspect;
       
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (maintainWidth)
        {
            this.GetComponent<Camera>().orthographicSize = defaultWidth / this.GetComponent<Camera>().aspect;

         }

	}
}
