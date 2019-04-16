using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VortexScript : MonoBehaviour {

	private float intervaltime;
	private Vector3[] positions = new Vector3[9];
	private int index=0;
	// Use this for initialization
	void Start () {
		intervaltime=0.7f;

		positions [0] = new Vector3 (-7.0f,12.0f,11.0f);
		positions [1] = new Vector3 (0.0f,12.0f,11.0f);
		positions [2] = new Vector3 (7.0f,12.0f,11.0f);

		positions [3] = new Vector3 (-7.0f,5.0f,11.0f);
		positions [4] = new Vector3 (0.0f,5.0f,11.0f);
		positions [5] = new Vector3 (7.0f,5.0f,11.0f);

		positions [6] = new Vector3 (-7.0f,-2.0f,11.0f);
		positions [7] = new Vector3 (0.0f,-2.0f,11.0f);
		positions [8] = new Vector3 (7.0f,-2.0f,11.0f);

	}

	// Update is called once per frame
	void Update () {
		this.GetComponent<Transform> ().Rotate (0.0f,0.0f,7.0f);
		if (intervaltime < 0) {
			intervaltime = 0.7f;
			if (this.GetComponent<Transform> ().name.Equals("Quad"+index)) {
				this.GetComponent<Transform> ().position=positions[index];
			}
			if (index < 8) {
				index++;
			} else {
				index = 0;
			}
		} else {
			intervaltime -= Time.deltaTime;
			if (this.GetComponent<Transform> ().name.Equals("Quad"+index)) {
				this.GetComponent<Transform> ().Translate (0, 0, -5 * Time.deltaTime);
			}
		}
	}


}
