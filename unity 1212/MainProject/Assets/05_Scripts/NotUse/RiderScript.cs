using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderScript : MonoBehaviour {

    public int health = 120;
    public int Damage = 30;
    public int RCore = 3;
    public float AttSpeed;
    public float AttDistance;
    public float moveSpeed = 0.8f;
    public bool canMove = false;
    public GameObject RiderTarget;

    // Use this for initialization
    void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
        RiderTarget = GetComponent<FaceTarget2>().Target;

        if (canMove == true && GetComponent<AllAnim>().BoolWalk == true)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }

        AttDistance = Vector3.Distance(transform.position,RiderTarget.transform.position);
        if (AttDistance <= 1.1)
        {
            GetComponent<AllAnim>().BoolWalk = false;
            GetComponent<AllAnim>().BoolAttack = true;
            
        }
        else
        {
            GetComponent<AllAnim>().BoolWalk = true;
            GetComponent<AllAnim>().BoolAttack = false;
        }

       /* if (health <= 0)
        {
            Dead();
        }*/



	}

    private void OnCollisionEnter(Collision houseCollision)
    {
        if (houseCollision.collider.tag == "Floor")
        {
            canMove = true;
        }



    }

    /*void Dead()
    {
        GetComponent<AllAnim>().BoolWalk = false; 
        GetComponent<AllAnim>().BoolDead = true;
        GetComponent<DestroyMe>().isDead = true;
       
    }*/
}
