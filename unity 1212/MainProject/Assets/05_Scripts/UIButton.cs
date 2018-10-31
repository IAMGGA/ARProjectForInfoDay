using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour {

    public GameObject BuyPanel;
    public GameObject BuyButton;

	// Use this for initialization
	void Start () {
        BuyPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenPanel()
    {
        BuyPanel.SetActive(true);
        BuyButton.SetActive(false);
    }

    public void ClosePanel()
    {
        BuyPanel.SetActive(false);
        BuyButton.SetActive(true);
    }

}
