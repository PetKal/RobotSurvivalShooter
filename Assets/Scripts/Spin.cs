﻿using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	public float x =0f;
	public float y =0f;
	public float z =0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (x, y, z) * Time.deltaTime);
	}
}
