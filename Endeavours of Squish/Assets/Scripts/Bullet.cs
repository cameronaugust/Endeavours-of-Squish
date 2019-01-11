﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public float TimeToLive = 5f;
    // Start is called before the first frame update
    void Start() { 
    {
        rb.velocity = transform.up * speed;
        Destroy(gameObject, TimeToLive);
    }

}

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Collision code for planets in terms of the bullets disapearing
    }
}
