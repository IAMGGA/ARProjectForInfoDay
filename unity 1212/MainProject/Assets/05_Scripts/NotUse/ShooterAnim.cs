using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterAnim : MonoBehaviour {

    Animator AnimatorShooter;
    public bool BoolWalk, BoolDead, BoolAttack;



	// Use this for initialization
	void Start () {
        AnimatorShooter = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        AnimatorShooter.SetBool("BoolWalk", BoolWalk);
        AnimatorShooter.SetBool("BoolDead", BoolDead);
        AnimatorShooter.SetBool("BoolAttack", BoolAttack);
    }

    void WillDestroy()
    {
        GetComponent<DestroyMe>().isDead = true;
    }

}
