using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyMaxHealth;

    [SerializeField]
    private float currentHealth;

    public float goodRep;
    public float badRep;
    public GameObject Player;
    public Enemy enemy;
    public PlayerController rep;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = enemyMaxHealth;
        rep = FindObjectOfType <PlayerController>();
    }

    public void addDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Reputation(goodRep, badRep);
            Debug.Log("Points earned");
            MakeDead();
            Debug.Log("Planet Destroyed");
        }
    }

    void MakeDead()
    {
        Destroy(enemy.planet.gameObject);
        Destroy(enemy.spawnedBoundary.gameObject);

    }
    void Reputation(float g, float b)
    {
        
            Debug.Log("Gained");
            rep.IncreaseGoodRep(g);
            rep.IncreaseBadRep(b);
        

    }
}
