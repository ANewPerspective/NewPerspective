using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour {

	public GameObject cube;
	public GameObject sphere;


	void Start () {
		
	}
	

	void Update () {

		if (Input.GetKeyUp (KeyCode.Space)) 
		{
			if (cube.activeInHierarchy == true) {
				cube.SetActive (false);
				sphere.SetActive (true);
				sphere.transform.position = cube.transform.position;
			} else {
				cube.SetActive (true);
				sphere.SetActive (false);
				cube.transform.position = sphere.transform.position;
			}
		}
	}
}
