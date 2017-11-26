using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laptime : MonoBehaviour {

	public static int min,sec;
	public static float mili;
	public static string milidis;

	public GameObject minb,secb,milib;


	
	// Update is called once per frame
	void Update () {
		mili += Time.deltaTime * 10;
		milidis = mili.ToString ("F0");
		milib.GetComponent<Text> ().text=""+milidis;

		if (mili >= 10) {
			mili = 0;
			sec++;
		}
		if (sec <= 9) {
			secb.GetComponent<Text> ().text = "0" + sec + ".";
		} else {
			secb.GetComponent<Text> ().text =""+ sec + ".";

		}
		if (sec >= 60) {
			sec = 0;
			min++;
		}
		if (min <= 9) {
			minb.GetComponent<Text> ().text = "0" + min + ":";

		} 
		else {
			minb.GetComponent<Text> ().text =""+ min + ":";

		}
	}
}
