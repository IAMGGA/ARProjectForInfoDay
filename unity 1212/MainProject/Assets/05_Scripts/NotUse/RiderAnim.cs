using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderAnim : MonoBehaviour {

    Animator AnimatorRider;
    public bool BoolWalk, BoolAttack, BoolDead;
    public GameObject AttackTarget;

	// Use this for initialization
	void Start () {
        AnimatorRider = GetComponent<Animator>();
        AttackTarget = GetComponent<FaceTarget2>().Target;
	}
	
	// Update is called once per frame
	void Update () {
        AnimatorRider.SetBool("BoolWalk", BoolWalk);
        AnimatorRider.SetBool("BoolAttack", BoolAttack);
        AnimatorRider.SetBool("BoolDead", BoolDead);
	}

    void WillDestroy(){
        GetComponent<DestroyMe>().isDead = true;
    }

    void AddAttack()
    {
       
    }

}
