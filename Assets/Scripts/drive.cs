using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour {
    public float movetime = 0.1f;
    public LayerMask blockingLayer;

    private Vector3 bikeMovement;
	private float bikeRotation;
	private float totalRotation;
	private float bikeDirection;

	// Use this for initialization
	protected virtual void Start () {
        bikeMovement = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.F)){
			totalRotation -= 90;
		}
		else if(Input.GetKeyDown(KeyCode.G)){
			totalRotation += 90;
		}

		//float bikeVertical = Input.GetAxis ("Vertical") * 90;

		//float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;

		//Quaternion target = Quaternion.Euler(0, bikeRotation, 0);
		transform.Rotate(Vector3.up * totalRotation);
		totalRotation = 0f;


		bikeMovement = (Vector3.forward * 0.01f);


		transform.position += transform.forward * Time.deltaTime;
        //transform.position = new Vector3(bikeMovement.x, transform.position.y, transform.position.z);
	}
}
