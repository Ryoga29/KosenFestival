﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_gene : MonoBehaviour {

    public GameObject FloorPrefab;
    public GameObject GoalPrefab;

    private float i, j;

	// Use this for initialization
	void Start () {

        for (i=0.0f;i<300.0f;i++)
        {
            for (j=-1.0f;j<4.0f;j++)
            {
                GameObject Floor = Instantiate(FloorPrefab) as GameObject;

                Floor.transform.position = new Vector3(0.0f+j,0.0f,0.0f+i);
            }
        }
        
        //Goal
        for (j=-1.0f;j<4.0f;j++)
        {
             GameObject Goal = Instantiate(GoalPrefab) as GameObject;

            Goal.transform.position = new Vector3(0.0f+j,0.0f,0.0f+i);
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
