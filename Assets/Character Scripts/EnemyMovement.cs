using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    public int speed;
    // Use this for initialization
    private Rigidbody2D _rigidBody;
    Animator _animator;
	void Start () {
        speed = 1;
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(_rigidBody.position.x < 290) {

            MoveRight();
           
        }
        StopMovement();
	}
    public void MoveRight() {
        Vector2 movementVector = new Vector2(1f, 0f);
        _rigidBody.MovePosition(_rigidBody.position + movementVector * Time.deltaTime);
        _animator.SetBool("isWalking", true);
        _animator.SetFloat("movement_x", movementVector.x);
        Debug.Log("X Position: " + transform.position.x);
    }
    public void MoveLeft() {
        Vector2 movementVector = new Vector2(-1f, 0f);
        _rigidBody.MovePosition(_rigidBody.position + movementVector * Time.deltaTime);
        _animator.SetBool("isWalking", true);
        _animator.SetFloat("movement_x", movementVector.x);

    }
    public void StopMovement() {
        /*Stop skeleton's movement and return to the idle state.
        */
        _animator.SetBool("isWalking", false);
    }

    
}
