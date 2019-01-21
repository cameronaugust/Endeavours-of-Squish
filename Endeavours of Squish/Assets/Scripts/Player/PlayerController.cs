using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Stat health;
    [SerializeField]
    private Stat good;
    [SerializeField]
    private Stat bad;



    void FixedUpdate()
    {
      //check to see where the nearest planent is and if it is far away enough, regenerate health at slow rate
     }
    private void Awake()
    {
        health.Initialize();
        good.Initialize();
        bad.Initialize();

    }
    //increases values of rep from planet destroyed and monitors the values to HUD
    public void IncreaseGoodRep(float GoodRep)
    {
        Debug.Log("Adding Good");
        good.CurrentVal += GoodRep;
    }
    public void IncreaseBadRep(float BadRep)
    {
        Debug.Log("Adding Bad");
        bad.CurrentVal += BadRep;
    }

    public void addDamage(float damage)
    {
        health.CurrentVal -= damage;
        if (health.CurrentVal <= 0) makeDead();
    }
    private void makeDead()
    {
        SceneManager.LoadScene("Death Screen");
        Destroy(gameObject);
        
    }
}
