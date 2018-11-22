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

    public void Spwanaa()
    {
        if (CoolDown <= 0)
        {
            Instantiate(Army[0], spwan.transform.position, Quaternion.identity);
            CoolDown = 2;
        }
    }

    public void SpwanRider()
    {
        if (CoolDown <= 0 && player.GetComponent<Player>().MyCore >= 3 )
        {
            player.GetComponent<Player>().MyCore -= 3;
            Instantiate(Army[0], spwan.transform.position, Quaternion.identity);
            CoolDown = 2;
        }
    }

    public void SpwanShooter()
    {
        if (CoolDown <= 0 && player.GetComponent<Player>().MyCore >= 2)
        {
            player.GetComponent<Player>().MyCore -= 2;
            Instantiate(Army[1], spwan.transform.position, Quaternion.identity);
            CoolDown = 2;
        }
    }

    public void SpwanSword()
    {
        if (CoolDown <= 0 && player.GetComponent<Player>().MyCore >= 1)
        {
            player.GetComponent<Player>().MyCore -= 1;
            Instantiate(Army[2], spwan.transform.position, Quaternion.identity);
            CoolDown = 2;
        }
    }

}
