using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carengine : MonoBehaviour {

	public Transform path;

	public float maxsteerangle=45f;
	public WheelCollider wheelfl, wheelfr;
	private List<Transform> nodes;
	private int currentnode=0;
	// Use this for initialization
	void Start () {
		Transform[] pathtransform = path.GetComponentsInChildren<Transform> ();
		nodes = new List<Transform> ();

		for (int i = 0; i < pathtransform.Length; i++) {
			if (pathtransform [i] != path.transform) {
				nodes.Add (pathtransform [i]);
			}
		}
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		applysteer ();
		Drive ();
		checkwaypoint ();
	}
	private void applysteer()
	{
		Vector3 relativevector = transform.InverseTransformPoint (nodes[currentnode].position);

		float newsteer = (relativevector.x / relativevector.magnitude)*maxsteerangle;
		wheelfl.steerAngle = newsteer;
		wheelfr.steerAngle = newsteer;

	}


	private void Drive()
	{
		
		wheelfl.motorTorque = 50f;
		wheelfr.motorTorque = 50f;
	}
	void checkwaypoint()
	{
		if (Vector3.Distance (transform.position, nodes [currentnode].position) < 1f) {
			if (currentnode == nodes.Count - 1) {
				currentnode = 0;
			} else {
				currentnode++;
			}
		}
	}
}
