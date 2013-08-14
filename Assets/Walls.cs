using UnityEngine;
using System.Collections;

public class Walls : MonoBehaviour {
	public GameObject wallCube;
	public float boardSize = 10;
	public float boardHeight = 10;
	
	// Use this for initialization
	void Start () {
		GameObject tempCube;
		
		for (int i = 0; i < 4; i++) {
			
			switch (i) {
			case 0:
				tempCube = (GameObject)Instantiate(wallCube, new Vector3(-boardSize / 2f - 0.5f, boardHeight / 2f, 0.5f), Quaternion.Euler(0, 90, 0));
				tempCube.transform.localScale = new Vector3(boardSize + 1, boardHeight, 1);
				
				tempCube = (GameObject)Instantiate(wallCube, new Vector3(-(boardSize / 2f) / 3f, (boardHeight - 1) / 2f, 0), Quaternion.Euler(0, 90, 0));
				tempCube.transform.localScale = new Vector3(boardSize, boardHeight - 1, 0.2f);
				
				break;
				
			case 1:
				tempCube = (GameObject)Instantiate(wallCube, new Vector3(0.5f, boardHeight / 2f, boardSize / 2f + 0.5f), Quaternion.identity);
				tempCube.transform.localScale = new Vector3(boardSize + 1, boardHeight, 1);
				
				tempCube = (GameObject)Instantiate(wallCube, new Vector3(0, (boardHeight - 1) / 2f, (boardSize / 2f) / 3f), Quaternion.identity);
				tempCube.transform.localScale = new Vector3(boardSize, boardHeight - 1, 0.2f);
				
				break;
				
			case 2:
				tempCube = (GameObject)Instantiate(wallCube, new Vector3(boardSize / 2f + 0.5f, boardHeight / 2f, -0.5f), Quaternion.Euler(0, 90, 0));
				tempCube.transform.localScale = new Vector3(boardSize + 1, boardHeight, 1);
				
				tempCube = (GameObject)Instantiate(wallCube, new Vector3((boardSize / 2f) / 3f, (boardHeight - 1) / 2f, 0), Quaternion.Euler(0, 90, 0));
				tempCube.transform.localScale = new Vector3(boardSize, boardHeight - 1, 0.2f);
				
				break;
				
			case 3:
				tempCube = (GameObject)Instantiate(wallCube, new Vector3(-0.5f, boardHeight / 2f, -boardSize / 2f - 0.5f), Quaternion.identity);
				tempCube.transform.localScale = new Vector3(boardSize + 1, boardHeight, 1);
				
				tempCube = (GameObject)Instantiate(wallCube, new Vector3(0, (boardHeight - 1) / 2f, -(boardSize / 2f) / 3f), Quaternion.identity);
				tempCube.transform.localScale = new Vector3(boardSize, boardHeight - 1, 0.2f);
				
				break;
			
			default:
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
