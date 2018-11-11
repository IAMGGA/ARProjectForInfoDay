using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTA1 : MonoBehaviour
{

    public GameObject Target;
    public GameObject Castle;
    public GameObject[] Enemy;
    public int EnemyList;
    bool isCastleTarget = false;

    // Use this for initialization
    void Start()
    {
        Target = null;
        Enemy = GameObject.FindGameObjectsWithTag("Player2Army");
        Castle = GameObject.Find("Player2Castle");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        EnemyList = GameObject.FindGameObjectsWithTag("Player2Army").Length;
        HaveEnemy();
        FindTarget();
        GoTarget();
    }

    void HaveEnemy()
    {
        if (EnemyList > 0)
        {
            isCastleTarget = false;
        }
    }
    void FindTarget()
    {
        if (isCastleTarget == false)
        {
            if (EnemyList > 0)
            {

                //Clear Enemy
                /*for (int i = 0; i < EnemyList; i++)
                {
                    Enemy[i] = null;
                }*/
                Enemy = GameObject.FindGameObjectsWithTag("Player2Army");
                Target = Enemy[0];
                if (Target.GetComponent<AllScript>().isDead == true)
                {
                    if (EnemyList > 1)
                    {
                        Target = Enemy[1];
                    }
                    else
                    {
                        Target = Castle;
                        isCastleTarget = true;
                    }
                }
            }
            else
            {
                Target = Castle;
                isCastleTarget = true;
            }
        }
    }

    void GoTarget()
    {
        if (Target != null)
        {
            Quaternion QuaternionR = Quaternion.LookRotation((Target.transform.position) - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, QuaternionR, 90 * Time.deltaTime);
        }
    }
}