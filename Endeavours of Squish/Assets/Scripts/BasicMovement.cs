 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Animator animator;
    public float moveHorizontal;
    public float moveVertical;
    public float speed;

    public Rigidbody2D player;
    private Vector2 movement; 

    // Start is called before the first frame update

    // Update is called once to several times per frame for better physics
    void FixedUpdate() {
		moveHorizontal = Input.GetAxis ("Horizontal") * speed;

		//checks to see if player is moving left
		if (moveHorizontal < 0) {
			animator.SetBool ("Left", true); 
			animator.SetBool ("Right", false); 
		} else {
			animator.SetBool ("Left", false);
		}
		//checks to see if player is moving right
		if (moveHorizontal > 0) {
			animator.SetBool("Right", true); 
			animator.SetBool("Left", false); 
		} else {
			animator.SetBool("Right", false);
		}
		if (moveVertical > 0) {
			animator.SetBool ("Up", true);
		} else {
			animator.SetBool ("Up", false);
		}
        moveVertical = Input.GetAxis("Vertical") * speed;

		movement = new Vector2(moveHorizontal, moveVertical);
        //player is a rigidbody using velocity 
        //player.velocity = movement * speed;
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
    }
}
