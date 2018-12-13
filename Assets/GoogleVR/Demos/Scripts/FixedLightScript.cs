using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedLightScript : MonoBehaviour {

	private float intervaltime;
	private Vector3[] positions = new Vector3[14];
	private int index=0;
	// Use this for initialization
	void Start () {
		intervaltime=Random.Range (1.0f, 1.5f);
		positions [0] = new Vector3 (-1.753f,5.0f,-0.737f);
		positions [1] = new Vector3 (-1.246f,5.0f,-0.346f);
		positions [2] = new Vector3 (-0.641f,5.0f,-0.102f);
		positions [3] = new Vector3 (0.0f,5.0f,0.0f);
		positions [4] = new Vector3 (0.641f,5.0f,-0.102f);
		positions [5] = new Vector3 (1.246f,5.0f,-0.346f);
		positions [6] = new Vector3 (1.753f,5.0f,-0.737f);

		positions [7] = new Vector3 (0.0f,6.762f,-0.732f);
		positions [8] = new Vector3 (0.0f,6.26f,-0.33f);
		positions [9] = new Vector3 (0.0f,5.623f,-0.115f);
		positions [10] = new Vector3 (0.0f,5.0f,0.0f);
		positions [11] = new Vector3 (0.0f,4.377f,-0.115f);
		positions [12] = new Vector3 (0.0f,3.74f,-0.33f);
		positions [13] = new Vector3 (0.0f,3.238f,-0.732f);
		this.GetComponent<Transform> ().position = positions [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (intervaltime < 0) {
			intervaltime = Random.Range (1.0f, 1.5f);
			if (index < 13) {
				index++;
			} else {
				index = 0;
			}
			this.GetComponent<Transform> ().position = positions [index];
		} else {
			intervaltime -= Time.deltaTime;
		}
	}



}
