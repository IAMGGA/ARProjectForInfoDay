using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour {

    public GameObject BuyPanel;
    public GameObject ControlerButton;

	// Use this for initialization
	void Start () {
        BuyPanel.SetActive(false);
        ControlerButton.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchPanel()
    {
        if (BuyPanel.active == false && ControlerButton.active == true)
        {
            BuyPanel.SetActive(true);
            ControlerButton.SetActive(false);
        }
        else if (BuyPanel.active == true && ControlerButton.active == false)
        {
            BuyPanel.SetActive(false);
            ControlerButton.SetActive(true);
        }
    }

    public void CollectPanel()
    {
        BuyPanel.SetActive(false);
        ControlerButton.SetActive(true);
    }

}
