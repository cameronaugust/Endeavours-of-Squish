 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Animator animator;
    public float moveHorizontal;
    public float moveVertical;
    public float speed;
	public bool up;
	public bool left;
	public bool right;
	public bool down;
    public Rigidbody2D player;
    private Vector2 movement; 

    // Start is called before the first frame update

    // Update is called once to several times per frame for better physics
    void FixedUpdate() {
		//moving Left and facing left
		if (moveHorizontal < 0) {
			animator.SetBool ("Left", true);  
		} else {
			animator.SetBool ("Left", false);
		}
		//moving Left and facing right
		//checks to see if player is moving right
		if (moveHorizontal > 0) {
			animator.SetBool("Right", true); 
		} else {
			animator.SetBool("Right", false);
		}

		if (moveVertical > 0) {
			animator.SetBool ("Up", true);
		} else {
			animator.SetBool ("Up", false);
		}


		//applying movement
		moveHorizontal = Input.GetAxis ("Horizontal") * speed;
        moveVertical = Input.GetAxis("Vertical") * speed;
		movement = new Vector2(moveHorizontal, moveVertical);
        player.AddForce(movement * speed);
        faceMouse();
    }
    //comment
    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
        mousePosition.x - transform.position.x,
        mousePosition.y - transform.position.y
        );

        transform.up = direction;

		if (mousePosition.x < player.position.x) {
			left = true;
			right = false;
		} else {
			right = true;
			left = false;
		}

		if (mousePosition.y < player.position.y) {
			down = true;
			up = false;
		} else {
			up = true;
			down = false;
		}
    }
}
