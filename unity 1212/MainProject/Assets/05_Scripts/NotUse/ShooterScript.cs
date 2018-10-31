using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour {

    // Use this for initialization
    public int health = 90;
    public int Damage = 20;
    public int RCore = 2;
    public float AttSpeed;
    public float AttDistance;
    public float moveSpeed = 0.65f;
    public bool canMove = false;
    public GameObject ShooterTarget;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        ShooterTarget = GetComponent<FaceTarget2>().Target;

        if (canMove == true && GetComponent<ShooterAnim>().BoolWalk == true)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }

        AttDistance = Vector3.Distance(transform.position, ShooterTarget.transform.position);
        if (AttDistance <= 4.0)
        {
            GetComponent<ShooterAnim>().BoolWalk = false;
            GetComponent<ShooterAnim>().BoolAttack = true;

        }
        else
        {
            GetComponent<ShooterAnim>().BoolWalk = true;
            GetComponent<ShooterAnim>().BoolAttack = false;
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
        GetComponent<ShooterAnim>().BoolWalk = false;
        GetComponent<ShooterAnim>().BoolDead = true;
        GetComponent<DestroyMe>().isDead = true;

    }
}

