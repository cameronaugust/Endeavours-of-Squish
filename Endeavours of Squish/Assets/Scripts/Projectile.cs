using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
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
    void OnTriggerEnter2D(Collider2D other)
    {
        DestroyProjectile();
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}

