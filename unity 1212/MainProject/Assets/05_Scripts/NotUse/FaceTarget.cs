using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTarget : MonoBehaviour {

    public GameObject Target;
    public GameObject Castle;

	// Use this for initialization
	void Start () {
        Target = null;
        Castle = GameObject.Find("player2Castle");
    }
	
	// Update is called once per frame
	void Update () {
        if (Target != null){
            Quaternion QuaternionR = Quaternion.LookRotation((Target.transform.position) - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, QuaternionR, 180 * Time.deltaTime);

        }
        else
        {
            Target = Castle;
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime);
        }
	}
}
