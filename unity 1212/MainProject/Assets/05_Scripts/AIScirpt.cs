using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScirpt : MonoBehaviour {

    public int core;
    public float cooldown = 25f;
    public float addCoreTime = 20;
    public float callArmy = 3f;
    public GameObject[] Armylist;
    public GameObject spwan;
    public int Caseint = 1;

    // Use this for initialization
    void Start () {
        //Armylist = this.gameObject.GetComponent<Spwan>().Army;
        core = 5;
    }
	
	// Update is called once per frame
	void Update () {
        TimeCounting();

        if (addCoreTime <= 0)
        {
            AddCore();
        }
        else if(callArmy <= 0)
        {
            AddArmy();
        }


    }

    public void TimeCounting()
    {
        cooldown -= Time.deltaTime;
        addCoreTime -= Time.deltaTime;
        callArmy -= Time.deltaTime;
    }

    public void AddCore() {
        core++;
        addCoreTime = 10f;
    }

    public void AddArmy()
    {
        Caseint = Random.Range(1, 3);
        if (cooldown <= 0)
        {
            switch (Caseint)
            {
                case 1:
                    if (core >= 3)
                    {
                        core -= 3;
                        Instantiate(Armylist[0], spwan.transform.position, Quaternion.identity);
                        cooldown = 15;
                    }
                    break;
                case 2:
                    if (core >= 2)
                    {
                        core -= 2;
                        Instantiate(Armylist[1], spwan.transform.position, Quaternion.identity);
                        cooldown = 10;
                    }
                    break;
                case 3:
                    if (core >= 1)
                    {
                        core -= 1;
                        Instantiate(Armylist[2], spwan.transform.position, Quaternion.identity);
                        cooldown = 15;
                    }
                    break;
            }
        }
        callArmy = 3f;
    }

}
