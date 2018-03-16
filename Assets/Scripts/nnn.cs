/*using UnityEngine;
using System.Collections;
public class nnn : MonoBehaviour 
{public Transform m;    float rotSpeed = 3; public float rotationSpeed = 100.0F;
    void OnMouseDrag()
    {
		
        //float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
        //float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;
		float rotY = Input.GetAxis("Mouse Y")*rotSpeed;
		//float rotation = 5 * rotationSpeed;
		//rotation *= Time.deltaTime;
        //transform.Rotate(Vector3.up, -rotX);
		transform.Rotate(0, 0, -rotY);
		if(m.eulerAngles.z >= 350.0f && m.eulerAngles.z >= 359.0f)
			transform.Rotate(0, 0, 0);
		if(m.eulerAngles.z >= 91.0f && m.eulerAngles.z >= 100.0f)
			transform.Rotate(0, 0, 0);
		
        //transform.Rotate(Vector3.right, rotY);
        //transform.Rotate(Vector3.right, rotY);
    }
	void OnMouseUp(){
		Rigidbody2D h = GetComponent<Rigidbody2D>();
		h.isKinematic = true;
		//h.bodyType = "Dynamic";
		h.AddForce(100f, 300f);
		Debug.Log("Mouse Up");
		/* HingeJoint2D hinge = GetComponent<HingeJoint2D>();
        JointMotor2D motor = hinge.motor;
        //motor.force = 100;
        motor.motorSpeed = 90;
        //motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;*/
	/*}
}*/