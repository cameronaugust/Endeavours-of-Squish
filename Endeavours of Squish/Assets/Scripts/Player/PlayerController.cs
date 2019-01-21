﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public void increaseGoodRep(float GoodRep)
    {
        good.CurrentVal += GoodRep;
    }
    public void increaseBadRep(float BadRep)
    {
        bad.CurrentVal += BadRep;
    }

    public void addDamage(float damage)
    {
        health.CurrentVal -= damage;
        if (health.CurrentVal <= 0) makeDead();
    }
    private void makeDead()
    {
        Destroy(gameObject);
    }
}