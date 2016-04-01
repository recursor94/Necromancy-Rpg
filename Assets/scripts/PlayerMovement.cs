using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour, IPauseable {
		
	const int DEFAULT_SPEED = 1;


	Rigidbody2D rBody;		
	Animator animator;
	private int speed;
    private bool isPaused;

	// Use this for initialization


	void Start () {
			

		rBody = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
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
			animator.SetBool ("is_walking", true);
			animator.SetFloat ("input_x", movementVector.x);
			animator.SetFloat ("input_y", movementVector.y);
			
	}
		else {

			animator.SetBool("is_walking", false);

		}
		rBody.MovePosition (rBody.position + (movementVector * speed) * Time.deltaTime);
	}

    public void OnPause() {
        isPaused = true;
        animator.SetBool("is_walking", false); //set player's sprite back to idle state when paused
    }

    public void OnResume() {
        isPaused = false;
    }
}