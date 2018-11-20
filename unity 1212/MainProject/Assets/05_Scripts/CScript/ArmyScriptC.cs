using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyScriptC : MonoBehaviour {

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

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Player2Army")
        {
            MyTarget = GetComponent<FindTarget2>().Target;
        }
        else if (this.gameObject.tag == "Player1Army")
        {
            MyTarget = GetComponent<FindTarget1>().Target;
        }

        if (canMove == true && GetComponent<AllAnimC>().BoolWalk == true)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }

        AttDistance = Vector3.Distance(transform.position, MyTarget.transform.position);
        if (AttDistance <= AttDistanceMax)
        {
            GetComponent<AllAnimC>().BoolWalk = false;
            GetComponent<AllAnimC>().BoolAttack = true;
            /*if (ArmyList[1])
            {
                Instantiate(Bullet, ShooterPoint.transform.position, Quaternion.identity);
            }*/
        }
        else
        {
            GetComponent<AllAnimC>().BoolWalk = true;
            GetComponent<AllAnimC>().BoolAttack = false;
        }
        if (MyTarget.tag != "Castle")
        {
            if (MyTarget.GetComponent<DestroyMeC>().isDead == true)
            {
                GetComponent<AllAnimC>().BoolWalk = true;
                GetComponent<AllAnimC>().BoolAttack = false;
            }
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
