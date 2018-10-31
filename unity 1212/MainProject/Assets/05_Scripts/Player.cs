using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public int health;
    public float DeadTime = 3;
    public bool isDead = false;

    // Use this for initialization
    void Start()
    {

    }

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
        isDead = true;


    }

}