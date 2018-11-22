using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintRotation : MonoBehaviour {

    public float RotationSpeed = 5f;

	
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
	}
}
