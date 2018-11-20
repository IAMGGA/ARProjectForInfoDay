using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllAnim : MonoBehaviour {

    Animator AnimatorAll;
    public bool BoolWalk, BoolAttack, BoolDead;
    public GameObject Target;
    public GameObject Bullet, ShooterPoint;
    public bool[] ArmyList = new bool[3];

  //  public float speed = 1;

    // Use this for initialization
    void Start()
    {
        AnimatorAll = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Player2Army")
        {
            Target = GetComponent<FaceTarget2>().Target;
        }else if (this.gameObject.tag == "Player1Army")
        {
            Target = GetComponent<FaceTarget1>().Target;
        }
        AnimatorAll.SetBool("BoolWalk", BoolWalk);
        AnimatorAll.SetBool("BoolAttack", BoolAttack);
        AnimatorAll.SetBool("BoolDead", BoolDead);
    }

    void WillDestroy()
    {
        GetComponent<DestroyMe>().isDead = true;
    }

    void AddAttack()
    {
        if (Target.GetComponent<Player>() == true)
        {
            Target.GetComponent<Player>().health -= GetComponent<ArmyScript>().Damage;
        }
        else
        {
            Target.GetComponent<DestroyMe>().health -= GetComponent<ArmyScript>().Damage;
        }
    }

    void Shoot()
    {
        if (ArmyList[1])
        {
            Instantiate(Bullet, ShooterPoint.transform.position, Quaternion.identity);
            /*Quaternion QuaternionR = Quaternion.LookRotation((Target.transform.position) - Bullet.transform.position);
            Bullet.transform.rotation = Quaternion.Slerp(transform.rotation, QuaternionR, 180 * Time.deltaTime);
            Bullet.transform.Translate(0, 0, speed * Time.deltaTime);*/
        }
    }
    

}
