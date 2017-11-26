using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makob : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public Rigidbody riri;
	public float speed;
	RaycastHit hit;
	public void makeit()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) 
		{
			hit.point = new Vector3 (hit.point.x, 0.5f, hit.point.z);
		}
		GameObject b = GameObject.FindGameObjectWithTag ("Player");
		Vector3 j = new Vector3 (b.transform.position.x, 0.5f, b.transform.position.z + 1);
			Instantiate (riri,j,Quaternion.identity);

	}

	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		GameObject b1 = GameObject.FindGameObjectWithTag ("sphere");

		b1.transform.position = Vector3.MoveTowards(b1.transform.position, hit.point, step);
        




    }
}
