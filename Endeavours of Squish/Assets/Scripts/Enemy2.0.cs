using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2.0 : MonoBehaviour {

	public Transform target;
	public float range = 15f;

	public string enemyTag = "Player";

	// Use this for initialization
	void Start () {
		InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}

	void UpdateTarget()
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
		float shortestDistance = Mathf.Infinity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDrawGizmosSelected ()
	{
		Gizmos.color = color.red;
		Gizmos.DrawWireSphere(transform.position, range);
}

