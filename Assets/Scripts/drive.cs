using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour {
    public float movetime = 0.1f;
    public LayerMask blockingLayer;

    private Vector3 bikeMovement;
	private float bikeRotation;
	private float totalRotation;

	// Use this for initialization
	protected virtual void Start () {
        bikeMovement = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.F)){
			totalRotation += 45;
		}
		else if(Input.GetKeyDown(KeyCode.G)){
			totalRotation += (-45);
		}

		//float bikeVertical = Input.GetAxis ("Vertical") * 90;

		//float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;

		//Quaternion target = Quaternion.Euler(0, bikeRotation, 0);
		transform.rotation = new Quaternion(0, totalRotation, 0, 1);


        bikeMovement.x -= 0.1f;
        //transform.position = new Vector3(bikeMovement.x, transform.position.y, transform.position.z);
	}
}
