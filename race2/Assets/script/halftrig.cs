using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halftrig : MonoBehaviour {

	public GameObject laptrig;
	public GameObject halfftrig;
	void onTriggerEnter()
	{
		laptrig.SetActive (true);
		halfftrig.SetActive (false);
	}
}
