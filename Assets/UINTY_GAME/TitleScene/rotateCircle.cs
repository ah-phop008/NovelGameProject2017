using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotateCircle : MonoBehaviour {
	float x;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		x -= Time.deltaTime * 10;
		transform.rotation = Quaternion.Euler (0, 0, x);

		
	}
}
