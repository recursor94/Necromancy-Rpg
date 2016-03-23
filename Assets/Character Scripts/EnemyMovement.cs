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

        /* if(_rigidBody.position.x < 290) {

            MoveRight();
           
        }
        else {
            StopMovement();
        }*/
        //MoveUp();
	}
    public void MoveUpRight() {
        /* move diagonol up and right
        */
        MoveUp();
        MoveRight();
    }
    public void UpLeft() {
        MoveUp();
        MoveLeft();
    }
    public void MoveDownRight() {
        MoveDown();
        MoveRight();

    }
    public void MoveDownLeft() {
        MoveDown();
        MoveLeft();
    }
    public void MoveRight() {
        Vector2 movementVector = new Vector2(1f, 0f);
        _rigidBody.MovePosition(_rigidBody.position + movementVector * Time.deltaTime);
        StartHorizontalAnimation(movementVector);
        Debug.Log("X Position: " + transform.position.x);
    }
    public void MoveLeft() {
        Vector2 movementVector = new Vector2(-1f, 0f);
        _rigidBody.MovePosition(_rigidBody.position + movementVector * Time.deltaTime);
        StartHorizontalAnimation(movementVector);
      

    }
    public void MoveUp() {
        Vector2 movementVector = new Vector2(0f, 1f);
        _rigidBody.MovePosition(_rigidBody.position + movementVector * Time.deltaTime);
        StartVerticalAnimation(movementVector);

    }
    public void MoveDown() {
        Vector2 movementVector = new Vector2(0f, -1f);
        _rigidBody.MovePosition(_rigidBody.position + movementVector * Time.deltaTime);
        StartVerticalAnimation(movementVector);
    }
    public void StopMovement() {
        /*Stop skeleton's movement and return to the idle state.
        */
        stopMovingAnimation();
    }
    public void StartHorizontalAnimation(Vector2 movementVector) {
        _animator.SetBool("isWalking", true);
        _animator.SetFloat("movement_x", movementVector.x);

    }
    public void StartVerticalAnimation(Vector2 movementVector) {
        _animator.SetBool("isWalking", true);
        _animator.SetFloat("movement_y", movementVector.y);
    }
    public void stopMovingAnimation() {
        _animator.SetBool("isWalking", false);
    }
    
}
