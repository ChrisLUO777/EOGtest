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

		positions [0] = new Vector3 (-3.39f,10.0f,4.13f);
		positions [1] = new Vector3 (3.44f,10.0f,4.13f);

		positions [2] = new Vector3 (-11.09f,5.0f,9.32f);
		positions [3] = new Vector3 (-6.6f,5.0f,13.0f);
		positions [4] = new Vector3 (-0.02f,5.0f,9.32f);
		positions [5] = new Vector3 (6.21f,5.0f,13.0f);
		positions [6] = new Vector3 (11.05f,5.0f,9.32f);

		positions [7] = new Vector3 (-3.29f,1.0f,4.13f);
		positions [8] = new Vector3 (3.58f,1.0f,4.13f);

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
				this.GetComponent<Transform> ().Translate (0, 0, 10 * Time.deltaTime);
			}
		}
	}


}
