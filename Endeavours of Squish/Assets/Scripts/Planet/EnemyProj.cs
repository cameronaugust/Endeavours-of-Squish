using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProj : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;

    public int damage;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //if enemy projectile hits target but player is not there
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }

    }

    //when the enemy projectile hits player
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
          

