using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainScriptFixed : MonoBehaviour {

    private float intervaltime;
    private Vector3[] positions = new Vector3[2];
    private int index = 0;
    // Use this for initialization
    void Start()
    {
        intervaltime=10.0f;
        positions[0] = new Vector3(0.0f, 50.0f, -1.25f);
        positions[1] = new Vector3(0.0f, 5.0f, -1.25f);
        this.GetComponent<Transform>().position = positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (intervaltime < 0)
        {
            if (index == 0)
            {
                index++;
                intervaltime = 5.0f;
            }
            else
            {
                index = 0;
                intervaltime = 10.0f;
            }
            this.GetComponent<Transform>().position = positions[index];
        }
        else
        {
            intervaltime -= Time.deltaTime;
        }
    }
}
