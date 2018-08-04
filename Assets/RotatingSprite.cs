using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingSprite : MonoBehaviour {

    public float rotationsPerMinute = 1;
    public bool inverseRotation = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        var rotationZAngle = (this.rotationsPerMinute * 360) * Time.deltaTime;

        if (this.inverseRotation)
        {
            rotationZAngle *= -1; 
        }

        this.transform.Rotate(0, 0, rotationZAngle);
    }
}
