using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAnim : MonoBehaviour {

    Animator AnimatorSword;
    public bool BoolWalk, BoolAttack, BoolDead;
    


	// Use this for initialization
	void Start () {
        AnimatorSword = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
        AnimatorSword.SetBool("BoolWalk", BoolWalk);
        AnimatorSword.SetBool("BoolAttack", BoolAttack);
        AnimatorSword.SetBool("BoolDead", BoolDead);
	}

    void WillDestroy()
    {
        GetComponent<DestroyMe>().isDead = true;
    }
}
