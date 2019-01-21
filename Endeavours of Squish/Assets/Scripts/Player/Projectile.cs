 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    //damage of this projectile
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
        if (other.CompareTag("Planet"))
        {
            EnemyHealth hurtEnemy = other.gameObject.GetComponent<EnemyHealth>();
            hurtEnemy.addDamage(damage);
            DestroyProjectile();
        }
        if (other.CompareTag("Boundary"))
        {
            DestroyProjectile();
        }
    }
    void DestroyProjectile()
    {
        Debug.Log("Deystroyed Proj");
        Destroy(gameObject);
    }
}

