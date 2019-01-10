 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float moveHoriztonal;
    public float moveVertical;
    public float speed;

    public Rigidbody2D player;
    private Vector2 movement; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once to several times per frame for better physics
    void FixedUpdate()
    {
        moveHoriztonal = Input.GetAxis("Horizontal") * speed;
        moveVertical = Input.GetAxis("Vertical") * speed;

        movement = new Vector2(moveHoriztonal, moveVertical);
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
