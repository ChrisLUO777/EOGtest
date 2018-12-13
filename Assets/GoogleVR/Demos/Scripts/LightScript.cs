using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {
	public float speed;

	private Vector3 curDir;
	private Vector3 thrust;
	// Use this for initialization
	void Start () {
		float x = Random.Range (0.0f, 1.0f);
		float y = Random.Range (0.0f, 1.0f);
		float z = Random.Range (0.0f, 1.0f);
		curDir = new Vector3 (x*speed, y*speed, z*speed);
		this.GetComponent<Rigidbody>().velocity=curDir;
	}
	
	// Update is called once per frame
	void Update () {
		thrust=this.GetComponent<Rigidbody>().velocity.normalized;
		this.GetComponent<Rigidbody> ().AddForce (thrust*0.5f);
	}
}
