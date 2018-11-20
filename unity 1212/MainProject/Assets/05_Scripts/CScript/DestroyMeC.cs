using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeC : MonoBehaviour {

    public int health;
    public float DeadTime = 3;
    public bool isDead = false;


    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Dead();
        }

        if (isDead == true)
        {
            Destroy(gameObject, DeadTime);
        }
    }

    void Dead()
    {
        GetComponent<AllAnimC>().BoolWalk = false;
        GetComponent<AllAnimC>().BoolDead = true;


    }

}

