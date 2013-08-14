using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeDropper : MonoBehaviour {
	public GameObject cubeObject;
	
	private float delay = 0.1f;
	private float nextCreateTime = 0;
	private float nextDestroyTime = 0;
	
	private List<GameObject> cubes;
	
	// Use this for initialization
	void Start () {
		cubes = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject cube;
		
		if (Input.GetMouseButton(0) && Time.time > nextCreateTime) {
			nextCreateTime = Time.time + delay;
			
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y));
			if (mousePos.x > 15 || mousePos.x < -15 || mousePos.y > 15 || mousePos.y < -15) return;
			cube = (GameObject)Instantiate(cubeObject, new Vector3(mousePos.x, mousePos.y + 40, mousePos.z), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
			cubes.Add(cube);
		}
	
		else if (Input.GetMouseButton(1) && Time.time > nextDestroyTime) {
			nextDestroyTime = Time.time + delay;
			
			int index = Random.Range(0, cubes.Count-1);
			cube = cubes[index];
			GameObject.Destroy(cube);
			cubes.RemoveAt(index);
		}
	}
}
