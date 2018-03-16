using UnityEngine;
using System.Collections;
public class Drag : MonoBehaviour {
	private Vector3 screenPoint;
	private Vector3 offset;
	/*void Start(){
		Debug.Log("START");
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}*/
	void OnMouseDown(){
		Debug.Log("MOUSE PRESSED");
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
		
	void OnMouseDrag(){
		Debug.Log("MOUSE PRESSED");
		Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
		transform.position = cursorPosition;
	}
	void OnMouseUp(){
			//HingeJoint2D name = GetComponent<HingeJoint2D>();
			GetComponent<HingeJoint2D>().enabled =  false;
			//name.enabled = false;
	}
}