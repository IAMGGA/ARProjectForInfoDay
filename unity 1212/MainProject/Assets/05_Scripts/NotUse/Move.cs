using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject house;
    public float moveSpeed = 0.5f;
    public bool canMove = false;
    public bool isDestroy = true;

    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (canMove == true)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
	}

    private void DestroyMe()
    {
        Destroy(house);
    }

    private void OnCollisionEnter(Collision houseCollision)
    {
        if(houseCollision.collider.tag == "Floor")
        {
            canMove = true;
        }

        if (houseCollision.collider.tag == "Dead")
        {
            DestroyMe();
        }

    }
}
