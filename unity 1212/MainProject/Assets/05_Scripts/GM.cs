using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    public int castleNo;
    public GameObject castle1;
    public GameObject castle2;

    public GameObject win;
    public GameObject lose;

    private void Start()
    {
      
    }

    // Update is called once per frame
    void Update () {
        castleNo = GameObject.FindGameObjectsWithTag("Castle").Length;
        if (castleNo < 2)
        {
            Time.timeScale = 0;
            if (castle1)
            {
                lose.SetActive(true);
            }
            else
            {
                win.SetActive(true);
            }
        }	
	}
}
