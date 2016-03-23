using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour, IPauseable {
		
	const int DEFAULT_SPEED = 1;


	Rigidbody2D rBody;		
	Animator Anim;
	private int speed;
    private bool isPaused;

	// Use this for initialization


	void Start () {
			

		rBody = GetComponent<Rigidbody2D> ();
		Anim = GetComponent<Animator> ();
		speed = DEFAULT_SPEED;
        isPaused = false;
	}


	
	// Update is called once per frame
	void FixedUpdate () {
        if(isPaused) {
            return;
        }
	
		Vector2 movementVector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw("Vertical"));
		if (movementVector != Vector2.zero) {
			Anim.SetBool ("is_walking", true);
			Anim.SetFloat ("input_x", movementVector.x);
			Anim.SetFloat ("input_y", movementVector.y);
			
	}
		else {

			Anim.SetBool("is_walking", false);

		}
		rBody.MovePosition (rBody.position + (movementVector * speed) * Time.deltaTime);
	}

    public void OnPause() {
        isPaused = true;
        Anim.SetBool("is_walking", false);
    }
}