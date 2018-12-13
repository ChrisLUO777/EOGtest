using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLightScript : MonoBehaviour {

	private float intervaltime;
	private float X;
	private float Y;
	private float Z;
	private Vector3 rposition;
	// Use this for initialization
	void Start () {
		intervaltime=Random.Range (1.0f, 1.5f);
		X = Random.Range (-1.0f, 1.0f);
		Y = Random.Range (6.0f, 4.0f);
		Z = Random.Range (-0.7f, 0.0f);
		rposition = new Vector3 (X, Y, Z);
		this.GetComponent<Transform> ().position = rposition;
	}
	
	// Update is called once per frame
	void Update () {
		if (intervaltime < 0) {
            intervaltime = Random.Range(1.0f, 1.5f);
            X = Random.Range(-1.0f, 1.0f);
            Y = Random.Range(6.0f, 4.0f);
            Z = Random.Range(-0.7f, 0.0f);
            rposition = new Vector3 (X, Y, Z);
			this.GetComponent<Transform> ().position = rposition;
		} else {
			intervaltime -= Time.deltaTime;
		}
	}
}
