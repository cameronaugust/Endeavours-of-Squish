using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Stat health;

     void FixedUpdate()
    {
      //check to see where the nearest planent is and if it is far away enough, regenerate health at slow rate
     }
    private void Awake()
    {
        health.Initialize();
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Damage indicated");
        health.CurrentVal -= 10;
    }
}
