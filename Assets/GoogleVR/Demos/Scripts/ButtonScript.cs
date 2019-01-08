using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	private int index;
	// Use this for initialization
	void Start () {
		index = SceneManager.GetActiveScene ().buildIndex;
	}


	// Update is called once per frame
	void Update () {
		
	}

	public void btClick()
	{
		if (index == 0) {
			SceneManager.LoadScene (1);
		}
		else if (index == 1) {
			SceneManager.LoadScene (2);
		}
		else if (index == 2) {
			SceneManager.LoadScene (3);
		}
		else if (index == 3) {
			SceneManager.LoadScene (0);
		}
	}
}
