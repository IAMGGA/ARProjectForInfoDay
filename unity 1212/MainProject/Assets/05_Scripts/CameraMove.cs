using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public GameObject MyCameraRig;
    private Touch initTouch = new Touch();

    public float rotationY = 0f;
    public GameObject orignalRotaion;

    public float rotationSpeed = 0.5f;
    public float dir = -1;

	// Use this for initialization
	void Start () {
        MyCameraRig.transform.Rotate(0,0,0);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		foreach(Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                initTouch = touch;
            }
            else if(touch.phase == TouchPhase.Moved)
            {
                float deltaY = initTouch.position.y - touch.position.y;
                rotationY = deltaY * Time.deltaTime * rotationSpeed * dir;
                MyCameraRig.transform.Rotate(0, rotationY, 0);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                initTouch = new Touch();
            }
        }
	}


}
