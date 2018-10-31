using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTarget1 : MonoBehaviour {

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
    void Update()
    {
        EnemyList = GameObject.FindGameObjectsWithTag("Player2Army").Length;
        //Debug.Log(EnemyList);
        if (Target != null && (!isCastleTarget || (isCastleTarget && EnemyList <= 0)))
        {
            //Enemy = GameObject.FindGameObjectsWithTag("Player1Army");
            //Debug.Log("Alexander");
            Quaternion QuaternionR = Quaternion.LookRotation((Target.transform.position) - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, QuaternionR, 180 * Time.deltaTime);
            
        }
        else
        {
            
            if (EnemyList > 0)
            {
                /*if (Target != Enemy[0])
                {
                    Target = null;
                }
                Enemy = GameObject.FindGameObjectsWithTag("Player1Army");*/
                for (int i = 0; i < EnemyList; i++)
                {
                    Enemy[i] = null;
                }
                Enemy = GameObject.FindGameObjectsWithTag("Player2Army");
                
                Target = Enemy[0];
                isCastleTarget = false;


            }
            else
            {
                Debug.Log("Alexander");
                Target = Castle;
                isCastleTarget = true;
                //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime);
            }
        }
    }

    public void FindTarget()
    {

    }
}

