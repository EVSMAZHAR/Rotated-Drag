using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    void Update() {
		if(Input.GetAxis("Mouse X")<0){
     
     print("Mouse moved left");
 }
 if(Input.GetAxis("Mouse X")>0){
     
     print("Mouse moved right");
 }
        //float translation = Input.GetAxis("Vertical") * speed;
        //float translation = 1 * speed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        float rotation = 5 * rotationSpeed;
        //translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        //transform.Translate(0, 0, translation);
        transform.Rotate(0, 0, rotation);
    }
}