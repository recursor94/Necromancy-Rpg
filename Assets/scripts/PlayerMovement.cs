using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
		
	const int DEFAULT_SPEED = 1;


	Rigidbody2D rBody;		
	Animator Anim;
	private int speed;

	// Use this for initialization


	void Start () {
			

		rBody = GetComponent<Rigidbody2D> ();
		Anim = GetComponent<Animator> ();
		speed = DEFAULT_SPEED;
	}


	
	// Update is called once per frame
	void FixedUpdate () {
	
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
}