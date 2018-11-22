using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Collecter : MonoBehaviour {

    private float HorizontalMove = 0f;
    private float VerticalMove = 0f;
    private Vector3 movement;

    public float runSpeed = 20f;

    public FixedJoystick joystick;

    protected ThirdPersonUserControl Control;


  


    // Use this for initialization
    void Start () {
        Control = GetComponent<ThirdPersonUserControl>();
	}
	
	// Update is called once per frame
	void Update () {

        Control.HInput = joystick.Horizontal;
        Control.VInput = joystick.Vertical;


        /*checkJoystick();
        
        movement = new Vector3(HorizontalMove, 0, VerticalMove);
        this.gameObject.GetComponent<Rigidbody>().AddForce(movement);*/
        /*if(joystick.Horizontal == 0 && joystick.Vertical == 0)
        {

        }*/


    }



    private void checkJoystick()
    {
        /*if (joystick.Horizontal >= 0.2f)
        {
            HorizontalMove = runSpeed;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            HorizontalMove = -runSpeed;
        }
        else
        {
            HorizontalMove = 0f;
        }*/

        if (joystick.Horizontal >= 0.2f)
        {
            HorizontalMove = runSpeed;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            HorizontalMove = -runSpeed;
        }
        else
        {
            HorizontalMove = 0f;
        }

        if (joystick.Vertical >= 0.2f)
        {
            VerticalMove = runSpeed;
        }
        else if (joystick.Vertical <= -0.2f)
        {
            VerticalMove = -runSpeed;
        }
        else
        {
            VerticalMove = 0f;
        }
        
    }
    


}
