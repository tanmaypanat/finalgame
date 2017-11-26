using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camrstb : MonoBehaviour {

	public GameObject thecar;
	public float carx,carz,cary;

	// Update is called once per frame
	void Update () {
		carx = thecar.transform.eulerAngles.x;
		cary = thecar.transform.eulerAngles.y;
		carz = thecar.transform.eulerAngles.z;
		transform.eulerAngles = new Vector3 (carx - carx, cary, carz - carz);
	}
}
