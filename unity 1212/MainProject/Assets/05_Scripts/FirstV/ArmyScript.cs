using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyScript : MonoBehaviour {

    public int health = 120;
    public int Damage = 30;
    public int Core = 3;
    public float AttSpeed;
    public float AttDistance;
    public float AttDistanceMax;
    public float moveSpeed = 0.8f;
    public bool canMove = false;
    public GameObject MyTarget;
    /*public GameObject Bullet,ShooterPoint;
    public bool[] ArmyList = new bool[3] ;*/ //Rider,Shooter,Sword//
    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Player2Army")
        {
            MyTarget = GetComponent<FaceTarget2>().Target;
        }else if (this.gameObject.tag == "Player1Army")
        {
            MyTarget = GetComponent<FaceTarget1>().Target;
        }

        if (canMove == true && GetComponent<AllAnim>().BoolWalk == true)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }

        AttDistance = Vector3.Distance(transform.position, MyTarget.transform.position);
        if (AttDistance <= AttDistanceMax)
        {
            GetComponent<AllAnim>().BoolWalk = false;
            GetComponent<AllAnim>().BoolAttack = true;
            /*if (ArmyList[1])
            {
                Instantiate(Bullet, ShooterPoint.transform.position, Quaternion.identity);
            }*/
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
        if(MyTarget.GetComponent<DestroyMe>().isDead == true)
        {
            GetComponent<AllAnim>().BoolWalk = true;
            GetComponent<AllAnim>().BoolAttack = false;
        }


    }

    private void OnCollisionEnter(Collision houseCollision)
    {
        if (houseCollision.collider.tag == "Floor")
        {
            canMove = true;
        }

        if(houseCollision.collider.tag == "Dead")
        {
            Destroy(gameObject);
        }

    }

    /*void Dead()
    {
        GetComponent<AllAnim>().BoolWalk = false; 
        GetComponent<AllAnim>().BoolDead = true;
        GetComponent<DestroyMe>().isDead = true;
       
    }*/
}
