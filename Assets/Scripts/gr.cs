using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class gr : MonoBehaviour {
public float yRotation = 5.0F; bool drag = false; float yyRotation;
	void OnMouseDrag(){
		 yRotation += Input.GetAxis("Mouse Y")*5;
		 //Debug.Log(yRotation);
		 Vector3 j = new Vector3(10, 0, -yRotation);
		 if(yRotation > -80 && yRotation < 80)
			transform.eulerAngles = j;
	}
	void OnMouseUp(){
		drag = true;
		//yyRotation = ransform.eulerAngles.z;
		yyRotation = yRotation;
		
	}
	void Update(){
		if(drag == true){
		 yyRotation += 5;
		 //Debug.Log(yRotation);
		 Vector3 j = new Vector3(10, 0, -yyRotation);
		 if(yyRotation <= 80)
		 transform.eulerAngles = j; 
	 else
		 drag = false;
	}
	}
}
