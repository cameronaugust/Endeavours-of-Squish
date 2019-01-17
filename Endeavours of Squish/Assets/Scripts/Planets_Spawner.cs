using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets_Spawner : MonoBehaviour {
	private int rand;

	public Sprite[] Sprite_Pic;

	// Use this for initialization
	void Start () {
		rand = Random.Range (0, Sprite_Pic.Length);
		GetComponent<SpriteRenderer> ().sprite = Sprite_Pic[rand];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
