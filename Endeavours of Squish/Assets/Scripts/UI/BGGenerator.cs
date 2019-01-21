using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGGenerator : MonoBehaviour 
{
	//prefabs for tiles
	public GameObject[] tile;

	//start of tiles
	public Vector3 tileStartPos;

	//tile spacing
	Vector2 tileSpacing;

	//grid width
	public int gridWidth;

	//grid height
	public int gridHeight;

	void Start()
	{
		//gets exact size of tiles
		tileSpacing = tile[0].GetComponent<Renderer>().bounds.size;

		//loop for number of row height
		for (int i = 0; i < gridHeight; i++)
		{
			//loop number of colums wide
			for (int j = 0; j < gridWidth; j++) 
			{
				//grabs a number between 0 and the number of tiles
				int randomTile = Random.Range(0, tile.Length);

				//creates game object based on chosen tile using random number
				//starting at start pos.x plus the tile spacing.x width times the grid width
				//by start pos.y plus tilespacing.y height times the grid height
				//using Quarterion to prevent rotation  in vector3
				GameObject go = Instantiate(tile[randomTile], new Vector3(tileStartPos.x + (j * tileSpacing.x), tileStartPos.y + (i * tileSpacing.y)), Quaternion.identity) as GameObject;

				//add all game objects as children of BGTiles
				go.transform.parent = GameObject.Find ("BGTiles").transform;
			}

		}

	}
} 


