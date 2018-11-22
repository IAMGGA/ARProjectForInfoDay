using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int MyCore;

    public float health;
    public bool isDead = false;

    public GameObject coretext;
    public Image yourhealthBar;
    public Image otherhealthBar;
    public float othercurrentHealth;
    public GameObject othercaslte;

    // Use this for initialization
    void Start()
    {
        MyCore = 3;
        coretext.GetComponent<Text>().text = "x " + MyCore;
        if (this.gameObject.name == "Player2Castle")
        {
            
            othercaslte = GameObject.Find("Player1Castle");
            othercurrentHealth = othercaslte.GetComponent<Player>().health;
        }else if (this.gameObject.name == "Player1Castle")
        {
            
            othercaslte = GameObject.Find("Player2Castle");
            othercurrentHealth = othercaslte.GetComponent<Player>().health;
        }
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
            Destroy(gameObject);
            return;

        }
        coretext.GetComponent<Text>().text = "x " + MyCore;

        yourhealthBar.fillAmount = health / 200;
        if (othercaslte)
        {
            otherhealthBar.fillAmount = othercaslte.GetComponent<Player>().health / 200;
        }
    }

    void Dead()
    {
        isDead = true;


    }

}