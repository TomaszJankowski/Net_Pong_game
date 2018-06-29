using UnityEngine;

public class Ratio : MonoBehaviour {

    public bool maintainWidth = true;
    float defaultWidth;

    
    void Start () {

      defaultWidth = this.GetComponent<Camera>().orthographicSize * this.GetComponent<Camera>().aspect;

    }
	
	
	void FixedUpdate () {

        if (maintainWidth)
        {
            this.GetComponent<Camera>().orthographicSize = defaultWidth / this.GetComponent<Camera>().aspect;
         }

	}
}
