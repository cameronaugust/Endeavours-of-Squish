using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    private Transform target;
	public float range = 15f;
	public GameObject target;
	public Rigidbody2D planet;
	 

    // Start is called before the first frame update
    void Start()
	{ 
		InvokeRepeating ("UpdateTarget", 0f, 0.5f);

    target = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwShots = startTimeBtwShots;
    }

	void UpdateTarget ()
	{

	}

    // Update is called once per frame
   

	Vector2 dir = target.position - transform.position;
	Quaternion lookRotation = Quaternion.LookRotation (dir);
	Vector2 rotation = lookRotation.eulerAngles; 
	planet.rotation = Quaternion.Euler (0f, rotation.y, 0f);

	}

	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, range);
	}
	
	void FixedUpdate()
    {
       

        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
