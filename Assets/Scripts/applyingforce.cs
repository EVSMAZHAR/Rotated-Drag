using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyingforce : MonoBehaviour {
	private Vector2 force;
	// Use this for initialization
	void Start () {
		force = new Vector2 (100.0f,300.0f);
	}
	void OnMouseDown(){
	GetComponent<Rigidbody2D>().isKinematic = false;
	GetComponent<Rigidbody2D>().AddForce(force);}
	// Update is called once per frame
	void Update () {
		
	}
}
