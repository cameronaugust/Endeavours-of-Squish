using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyMaxHealth;

    [SerializeField]
    private float currentHealth;
    public int goodRep;
    public int badRep;
    public PlayerController playerController;
    public Enemy enemy;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = enemyMaxHealth;
    }

    public void addDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0 && playerController != null) {
            reputation(goodRep, badRep);
            Debug.Log("Points earned");
            makeDead();
            Debug.Log("Planet Destroyed");
        }
    }
    
    void makeDead()
    {
        Destroy(self);
        Destroy(enemy.spawnedBoundary);
       
    }
    public void reputation(int g, int b)
    {
        playerController.increaseGoodRep(g);
        playerController.increaseBadRep(b);

    }

}
