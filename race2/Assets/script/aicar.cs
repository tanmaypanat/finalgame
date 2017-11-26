using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aicar : MonoBehaviour {

	public GameObject marker;
	public GameObject m0,m30,m31,m32,m33,m34,m35,m36,m37;
	public GameObject m1,m2,m3,m4,m5,m6,m7,m8,m9,m10,m11,m12,m13,m14,m15,m16,m17,m18,m19,m20,m21,m22,m23,m24,m25,m26,m27,m28,m29;
	public int markt;

	
	// Update is called once per frame
	void Update () {
		if (markt == 0) {
			marker.transform.position = m0.transform.position;
		}	
		if (markt == 1) {
			marker.transform.position = m1.transform.position;
		}	
		if (markt == 2) {
			marker.transform.position = m2.transform.position;
		}	
		if (markt == 3) {
			marker.transform.position = m3.transform.position;
		}	
		if (markt == 4) {
			marker.transform.position = m4.transform.position;
		}	
		if (markt == 5) {
			marker.transform.position = m5.transform.position;
		}	
		if (markt == 6) {
			marker.transform.position = m6.transform.position;
		}	if (markt == 7) {
			marker.transform.position = m7.transform.position;
		}	if (markt == 8) {
			marker.transform.position = m8.transform.position;
		}	if (markt == 9) {
			marker.transform.position = m9.transform.position;
		}	if (markt == 10) {
			marker.transform.position = m10.transform.position;
		}	if (markt == 11) {
			marker.transform.position = m11.transform.position;
		}	if (markt == 12) {
			marker.transform.position = m12.transform.position;
		}	if (markt == 13) {
			marker.transform.position = m13.transform.position;
		}	if (markt == 14) {
			marker.transform.position = m14.transform.position;
		}	if (markt == 15) {
			marker.transform.position = m15.transform.position;
		}	if (markt == 16) {
			marker.transform.position = m16.transform.position;
		}	if (markt == 17) {
			marker.transform.position = m17.transform.position;
		}	if (markt == 18) {
			marker.transform.position = m18.transform.position;
		}	if (markt == 19) {
			marker.transform.position = m19.transform.position;
		}	if (markt == 20) {
			marker.transform.position = m20.transform.position;
		}	if (markt == 21) {
			marker.transform.position = m21.transform.position;
		}	if (markt == 22) {
			marker.transform.position = m22.transform.position;
		}	if (markt == 23) {
			marker.transform.position = m23.transform.position;
		}	if (markt == 24) {
			marker.transform.position = m24.transform.position;
		}	if (markt == 25) {
			marker.transform.position = m25.transform.position;
		}	if (markt == 26) {
			marker.transform.position = m26.transform.position;
		}	if (markt == 27) {
			marker.transform.position = m27.transform.position;
		}	if (markt == 28) {
			marker.transform.position = m28.transform.position;
		}	if (markt == 29) {
			marker.transform.position = m29.transform.position;
		}	
		if (markt == 30) {
			marker.transform.position = m30.transform.position;
		}		if (markt == 31) {
			marker.transform.position = m31.transform.position;
		}		if (markt == 32) {
			marker.transform.position = m32.transform.position;
		}		if (markt == 33) {
			marker.transform.position = m33.transform.position;
		}		if (markt == 34) {
			marker.transform.position = m34.transform.position;
		}		if (markt == 35) {
			marker.transform.position = m35.transform.position;
		}		if (markt == 36) {
			marker.transform.position = m36.transform.position;
		}		if (markt == 37) {
			marker.transform.position = m37.transform.position;
		}	

	}
	IEnumerator OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "dream") {
			this.GetComponent<BoxCollider> ().enabled = false;
			markt+=1;
			if (markt == 38)
				markt = 0;
			yield return new WaitForSeconds (1);
			this.GetComponent<BoxCollider> ().enabled = true;
		}
	}

}
