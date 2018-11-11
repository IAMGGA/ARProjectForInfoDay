using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllScript : MonoBehaviour {

    public int health = 120;
    public int Damage = 30;
    public int Core = 3;
    public float AttDistance;
    public float AttDistanceMax;
    public float moveSpeed = 0.8f;
    public bool canMove = false;
    public GameObject MyTarget;

    Animator AnimatorAll;
    public bool BoolWalk, BoolAttack, BoolDead;
    public GameObject Bullet, ShooterPoint;
    public bool[] ArmyList = new bool[3];//Rider,Shooter,Sword//

    public float DeadTime = 3;
    public bool isDead = false;

    // Use this for initialization
    void Start () {
        AnimatorAll = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        GoDead();
        AllAnimation();
        WhatTarget();
        GoMove();
        GoAttack();
        

    }

    void WhatTarget()
    {
        if (this.gameObject.tag == "Player2Army")
        {
            MyTarget = GetComponent<FindTA2>().Target;
        }
        else if (this.gameObject.tag == "Player1Army")
        {
            MyTarget = GetComponent<FindTA1>().Target;
        }
    }

     void GoMove()
    {
        if (canMove == true && BoolWalk == true)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
    }

    void GoAttack()
    {
        AttDistance = Vector3.Distance(transform.position, MyTarget.transform.position);
        if (AttDistance <= AttDistanceMax)
        {
            BoolWalk = false;
            BoolAttack = true;
        }
        else
        {
            BoolWalk = true;
            BoolAttack = false;
        }
        if (MyTarget.tag != "Castle")
        {
            if (MyTarget.GetComponent<AllScript>().isDead == true)
            {
                BoolWalk = true;
                BoolAttack = false;
            }
        }
    }

    void GoDead()
    {
        if (health <= 0)
        {
            GetComponent<AllScript>().BoolWalk = false;
            GetComponent<AllScript>().BoolDead = true;
        }

        if (isDead == true)
        {
            Destroy(gameObject, DeadTime);
        }

}

    void AllAnimation()
    {
        AnimatorAll.SetBool("BoolWalk", BoolWalk);
        AnimatorAll.SetBool("BoolAttack", BoolAttack);
        AnimatorAll.SetBool("BoolDead", BoolDead);
    }


    void WillDestroy()
    {
        isDead = true;
    }

    void AddAttack()
    {
        if (MyTarget.GetComponent<Player>() == true)
        {
            MyTarget.GetComponent<Player>().health -= this.GetComponent<AllScript>().Damage;
        }
        else
        {
            MyTarget.GetComponent<AllScript>().health -= this.GetComponent<AllScript>().Damage;
        }
    }

    void Shoot()
    {
        if (ArmyList[1])
        {
            Instantiate(Bullet, ShooterPoint.transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter(Collision houseCollision)
    {
        if (houseCollision.collider.tag == "Floor")
        {
            canMove = true;
        }

        if (houseCollision.collider.tag == "Dead")
        {
            Destroy(gameObject);
        }

    }

}
