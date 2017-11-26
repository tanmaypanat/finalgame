using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour {


	void OnCollisionEnter(Collision collison)
	{
			Destroy (gameObject);
			Debug.Log ("kaboom");


	

	}
	void Update()
	{
		Destroy (gameObject, 0.5f);
	}

}
