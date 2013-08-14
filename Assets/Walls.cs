using UnityEngine;
using System.Collections;

public class Walls : MonoBehaviour {	
	private GameObject[] outerWalls;
	private GameObject[] innerWalls;
	
	// Use this for initialization
	void Start () {
		outerWalls = new GameObject[4];
		innerWalls = new GameObject[4];
		
		for (int i = 0; i < 4; i++) {
			GameObject outerWall = (GameObject)Resources.Load("Wall");
			Instantiate(outerWall);
				
			outerWall.transform.localScale = new Vector3(11, 10, 1);

			switch (i) {
			case 0:
				outerWall.transform.position = new Vector3(-5.5f, 0.5f, 0.5f);
				outerWall.transform.rotation = Quaternion.Euler(0, 90, 0);
				break;
				
			case 1:
				outerWall.transform.position = new Vector3(0.5f, 0.5f, 5.5f);
				outerWall.transform.rotation = Quaternion.identity;
				break;
				
			case 2:
				outerWall.transform.position = new Vector3(5.5f, 0.5f, -0.5f);
				outerWall.transform.rotation = Quaternion.Euler(0, 90, 0);
				break;
				
			case 3:
				outerWall.transform.position = new Vector3(-0.5f, 0.5f, -5.5f);
				outerWall.transform.rotation = Quaternion.identity;
				break;
			
			default:
				break;
			}
			
			outerWalls[i] = outerWall;
		}
		
		for (int i = 0; i < 4; i++) {
			GameObject innerWall = (GameObject)Resources.Load("Wall");
			Instantiate(innerWall);
			
			innerWall.transform.localScale = new Vector3(10, 9, 0.2f);
			
			switch (i) {
			case 0:
				innerWall.transform.position = new Vector3(-2.5f, 0.5f, 0);
				innerWall.transform.rotation = Quaternion.Euler(0, 90, 0);
				break;
				
			case 1:
				innerWall.transform.position = new Vector3(0, 0.5f, 2.5f);
				innerWall.transform.rotation = Quaternion.identity;
				break;
				
			case 2:
				innerWall.transform.position = new Vector3(2.5f, 0.5f, 0);
				innerWall.transform.rotation = Quaternion.Euler(0, 90, 0);
				break;
				
			case 3:
				innerWall.transform.position = new Vector3(0, 0.5f, -2.5f);
				innerWall.transform.rotation = Quaternion.identity;
				break;
			
			default:
				break;
			}
			
			innerWalls[i] = innerWall;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
