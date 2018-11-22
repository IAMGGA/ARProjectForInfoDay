using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float speed = 1f;
    public float rotateSpeed = 6.0f;
    public float gravity = 20.0f;

    public float HorizontalMove;
    public float VerticalMove;
    public FixedJoystick joystick;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    public int playerCore;
    public GameObject player;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
        player = GameObject.Find("Player2Castle");
        

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        checkJoystick();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, VerticalMove);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            
        }
        transform.Rotate(0, HorizontalMove, 0);
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

	}

    private void checkJoystick()
    {
        
        if (joystick.Horizontal >= 0.2f)
        {
            HorizontalMove = speed;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            HorizontalMove = -speed;
        }
        else
        {
            HorizontalMove = 0f;
        }

        if (joystick.Vertical >= 0.2f)
        {
            VerticalMove = speed;
        }
        else if (joystick.Vertical <= -0.2f)
        {
            VerticalMove = -speed;
        }
        else
        {
            VerticalMove = 0f;
        }


    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Paint")
        {
            player.GetComponent<Player>().MyCore += 1;
            Destroy(collision.gameObject);
        }
    }

}
