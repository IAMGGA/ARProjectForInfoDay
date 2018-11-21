using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

    public float moveSpeed = 0.5f;
    public bool canMove = false;
    Animator Anim;
    public bool BoolWalk;
    // Use this for initialization
    void Start()
    {
        Anim.SetBool("BoolWalk", BoolWalk);
    }
	// Update is called once per frame
	void Update () {
        if (canMove == true && BoolWalk == true)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
    }


    private void OnCollisionEnter(Collision houseCollision)
    {
        if (houseCollision.collider.tag == "Floor")
        {
            canMove = true;
        }

        

    }
}
