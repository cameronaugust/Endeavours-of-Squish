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
    void FixedUpdate()
    {
        //moving Left and facing left

        //applying movement
        moveHorizontal = Input.GetAxis("Horizontal") * speed;
        moveVertical = Input.GetAxis("Vertical") * speed;
        movement = new Vector2(moveHorizontal, moveVertical);
        player.AddForce(movement * speed);
        FaceMouse();
    }
    //comment
    void FaceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
        mousePosition.x - transform.position.x,
        mousePosition.y - transform.position.y
        );

        transform.up = direction;

        if (mousePosition.x < player.position.x)
        {
            animator.SetBool("FacingLeft", true);
            animator.SetBool("FacingRight", false);
        }
        else
        {
            animator.SetBool("FacingRight", true);
            animator.SetBool("FacingLeft", false);
        }

        if (mousePosition.y < player.position.y)
        {
            animator.SetBool("FacingUp", false);
            animator.SetBool("FacingDown", true);
        }
        else
        {
            animator.SetBool("FacingDown", false);
            animator.SetBool("FacingUp", true);
        }
    }
}
         

   

