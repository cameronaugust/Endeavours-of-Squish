using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioactivePlanet : MonoBehaviour {

	//Integers
	public int curhealth;
	public int maxhealth;

	//Floats
	public float distance;
	public float aggroRange;
	public float shootInterval;
	public float bulletSpeed = 100;
	public float bulletTimer;

	//Booleans
	public bool awake = false;
	public bool lookingRight = true;

	//References
	public GameObject bullet; 
	public Transform Target; 
	public Transform shootPoint; 

	void Awake() 
	{ 
		