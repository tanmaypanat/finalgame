using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpmake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public makob ma;
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0))
		{
			ma.makeit ();
		}
	}
}
