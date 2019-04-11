using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainScriptStreet : MonoBehaviour {

    private float intervaltime;
    private Vector3[] positions = new Vector3[2];
    private int index = 0;
    // Use this for initialization
    void Start()
    {
        intervaltime = 11.0f;
        positions[0] = new Vector3(107.36f, 123.0f, 10.0f);
        positions[1] = new Vector3(107.36f, 73.0f, 10.0f);
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
                intervaltime = 11.0f;
            }
            this.GetComponent<Transform>().position = positions[index];
        }
        else
        {
            intervaltime -= Time.deltaTime;
        }
    }
}
