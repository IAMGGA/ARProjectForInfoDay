using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public float speed =4f;
    public bool canDestroy = false;
    public float time = 0.8f;
    public bool canMove = false;
    public GameObject Target;

    // Use this for initialization
    void Start () {
        canMove = true;
        Destroy(gameObject, time);
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.tag == "Player2Amry")
        {
            Target = GetComponent<FaceTarget2>().Target;
        }else if(this.gameObject.tag == "Player1Army")
        {
            Target = GetComponent<FaceTarget1>().Target;
        }
        if (canMove == true)
        {
            /*Quaternion QuaternionR = Quaternion.LookRotation((Target.transform.position) - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, QuaternionR, 180 * Time.deltaTime);*/
            transform.Translate(0, speed * Time.deltaTime, speed * Time.deltaTime);
        }

        

	}
}
