using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newroute : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public Unit u1;


	RaycastHit hit;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Destroy (GameObject.FindGameObjectWithTag("Finish"));
			/*Transform retain = GameObject.FindGameObjectWithTag ("Player").transform;
			Destroy (GameObject.FindGameObjectWithTag ("Player"));*/
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				
				hit.point = new Vector3 (hit.point.x, 0f, hit.point.z);
			}
			//Vector3 loc = new Vector3 (retain.position.x,retain.position.y,retain.position.z);
			//Instantiate (GameObject.FindGameObjectWithTag ("Player"), loc, Quaternion.identity);
			Instantiate (GameObject.FindGameObjectWithTag("Finish"),hit.point,Quaternion.identity);

			u1.wapas ();
		}
	}
}
