using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets_Spawner : MonoBehaviour
{
    public GameObject volcano, robot, radioactive, skull, candy;
    
    [Range(0.0f,1)]
    public float enemyRatio = 0.5f;

    public void PlaceEnemy(Vector2 cords)
    {
        float rnd = Random.value;
        if (rnd < enemyRatio)
        {
            Instantiate(volcano, new Vector3(cords.x, cords.y + 1, 1), Quaternion.identity);
        }
        if (rnd >= 0.2f && rnd < 0.3f)
        {
            Instantiate(robot, new Vector3(cords.x, cords.y + 1, 1), Quaternion.identity);
        }
        if (rnd >= 0.3f && rnd < 0.7f)
        {
            Instantiate(radioactive, new Vector3(cords.x, cords.y + 1, 1), Quaternion.identity);
        }
        if (rnd >= 0.7f)
        {
            Instantiate(skull, new Vector3(cords.x, cords.y + 1, 1), Quaternion.identity);
        }
    }
}
