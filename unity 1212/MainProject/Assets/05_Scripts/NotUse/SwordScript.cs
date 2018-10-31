using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour {

    public int health = 100;
    public int Damage = 50;
    public int RCore = 1;
    public float AttSpeed;
    public float AttDistance;
    public float moveSpeed = 0.5f;
    public bool canMove = false;
    public GameObject SwordTarget;
    public bool Anim;

    // Use this for initialization
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        SwordTarget = GetComponent<FaceTarget2>().Target;

        if (canMove == true && GetComponent<SwordAnim>().BoolWalk == true)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }

        AttDistance = Vector3.Distance(transform.position, SwordTarget.transform.position);
        if (AttDistance <= 1.1)
        {
            GetComponent<SwordAnim>().BoolWalk = false;
            GetComponent<SwordAnim>().BoolAttack = true;

        }
        else
        {
            GetComponent<SwordAnim>().BoolWalk = true;
            GetComponent<SwordAnim>().BoolAttack = false;
        }

        if (health <= 0)
        {
            Dead();
        }



    }

    private void OnCollisionEnter(Collision houseCollision)
    {
        if (houseCollision.collider.tag == "Floor")
        {
            canMove = true;
        }



    }

    void Dead()
    {
        GetComponent<SwordAnim>().BoolWalk = false;
        GetComponent<SwordAnim>().BoolDead = true;
        GetComponent<DestroyMe>().isDead = true;

    }
}