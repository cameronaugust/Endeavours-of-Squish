using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rangeDistance;
    public float distanceToPlayer;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    private Transform player;
    public GameObject boundary;
    public GameObject spawnedBoundary;
    public GameObject planet;
    private bool boundaryOn = false;

    //values to set per planet
    public int goodRep;
    public int badRep;

    void Start()
    {
        //setting variable player to the object with Tag called "Player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //setting the time between shots to equal the time set to the original start time shot
        timeBtwShots = startTimeBtwShots;
    }

    void FixedUpdate()
    {
        if (player != null)
        {
            distanceToPlayer = Vector3.Distance(transform.position, player.position);
            if (distanceToPlayer < rangeDistance)
            {
                //checking if the time between the last shot is less than or equal to zero
                if (timeBtwShots <= 0)
                {
                    //creates planents assigned projectile
                    Instantiate(projectile, transform.position, Quaternion.identity);
                    //resets time after projectile has been created to the start time for next instatiation
                    timeBtwShots = startTimeBtwShots;
                }
                //if the time between shots is not less than or equal to zero (i.e. greater than zero) 
                else
                {
                    //sets time subtracted by the time elapsed
                    timeBtwShots -= Time.deltaTime;
                }

                //Rotation Code
                //Vector3 target = player.position;
                //intializes direction variable to rotate towards based on player location
                Vector2 direction = new Vector2(
                player.position.x - transform.position.x,
                player.position.y - transform.position.y
               );
                //sets the direction to rotate towards
                transform.up = direction;
            }
            if (distanceToPlayer < rangeDistance - .75 && boundaryOn == false)
            {
                AwakeBarrier();
            }
            void AwakeBarrier()
            {
                spawnedBoundary = Instantiate(boundary, transform.position, Quaternion.identity);
                boundaryOn = true;
            }
        }
    }
}


