using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour {
    public float movetime = 0.1f;
    public LayerMask blockingLayer;

    private Vector3 bikeMovement;


	// Use this for initialization
	protected virtual void Start () {
        bikeMovement = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        bikeMovement.x -= 0.1f;
        transform.position = new Vector3(bikeMovement.x, transform.position.y, transform.position.z);
	}
}
