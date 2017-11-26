using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {


	 public Transform targeta;
	float speed = 100;
	Vector3[] path;
	int targetIndex;
	RaycastHit hit;


	 void Start() {
		GameObject j = GameObject.FindGameObjectWithTag ("Finish");
		targeta = j.transform;
		PathRequestManager.RequestPath(transform.position,targeta.position, OnPathFound);
	}
	public void wapas() {
		targetIndex = 0;
		GameObject j = GameObject.FindGameObjectWithTag ("Finish");
		targeta = j.transform;
		PathRequestManager.RequestPath(transform.position,targeta.position, OnPathFound);
	}
	void Update()
	{
		

	}
	public void OnPathFound(Vector3[] newPath, bool pathSuccessful) {
		if (pathSuccessful) {
			path = newPath;
			targetIndex = 0;
			StopCoroutine("FollowPath");
			StartCoroutine("FollowPath");
		}
	}

	IEnumerator FollowPath() {
		Vector3 currentWaypoint = path[0];
		while (true) {
			if (transform.position == currentWaypoint) {
				targetIndex ++;
				if (targetIndex >= path.Length) {
					yield break;
				}
				currentWaypoint = path[targetIndex];
			}

			transform.position = Vector3.MoveTowards(transform.position,currentWaypoint,speed * Time.deltaTime);
			yield return null;

		}
	}

	public void OnDrawGizmos() {
		if (path != null) {
			for (int i = targetIndex; i < path.Length; i ++) {
				Gizmos.color = Color.blue;
				Gizmos.DrawCube(path[i], Vector3.one);

				if (i == targetIndex) {
					Gizmos.DrawLine(transform.position, path[i]);
				}
				else {
					Gizmos.DrawLine(path[i-1],path[i]);
				}
			}
		}
	}
}