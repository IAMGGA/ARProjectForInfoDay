using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spwan : MonoBehaviour {

    public GameObject spwan;
    //public GameObject house;
    public GameObject[] Army;
    public float CoolDown = 2;
    public GameObject[] SpwanButton;
    public GameObject player;

        private void Start()
    {
        player = GameObject.Find("Player2Castle");
    }
    
	
	// Update is called once per frame
	void Update () {
        CoolDown -= Time.deltaTime;
	}


    public void SpwanRider()
    {
        if (CoolDown <= 0 && player.GetComponent<Player>().MyCore >= 3 )
        {
            AddCore1();
            Instantiate(Army[0], spwan.transform.position, Quaternion.identity);
            CoolDown = 2;
        }
    }

    public void SpwanShooter()
    {
        if (CoolDown <= 0 && player.GetComponent<Player>().MyCore >= 2)
        {
            AddCore2();
            Instantiate(Army[1], spwan.transform.position, Quaternion.identity);
            CoolDown = 2;
        }
    }

    public void SpwanSword()
    {
        if (CoolDown <= 0 && player.GetComponent<Player>().MyCore >= 1)
        {
            AddCore3();
            Instantiate(Army[2], spwan.transform.position, Quaternion.identity);
            CoolDown = 2;
        }
    }


    public void AddCore1()
    {
        player.GetComponent<Player>().MyCore -= 3;
    }
    public void AddCore2()
    {
        player.GetComponent<Player>().MyCore -= 2;
    }
    public void AddCore3()
    {
        player.GetComponent<Player>().MyCore -= 1;
    }
}
