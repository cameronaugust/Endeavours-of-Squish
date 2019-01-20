using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);

        Debug.Log("Health; " + healthSystem.GetHealth());

        CMDebug.ButtonUI(new Vector2(100,100), "damage", () =>

    }

}
  
