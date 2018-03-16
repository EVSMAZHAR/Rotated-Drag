using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

class checking : MonoBehaviour{
	public GameObject orb;	public GameObject ob;	public float radius;	private float x = 0.0f;	public float radiusSpeed;	public float rotationSpeed;	private Transform centre;	private Transform gb;	private Vector3 desiredPos;private Vector3 screenPoint;
	private bool DragOut = false;
	private Vector3 offset;
	private Vector2 force;
	public Rigidbody2D rb;
	void Start()
	{
		centre = orb.transform;
		transform.position = new Vector3(-(centre.position.x + 5), centre.position.y, centre.position.z);
		gb = ob.transform;
		rb = GetComponent<Rigidbody2D>();
	}
	
		
	void OnMouseDown(){
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		//GetComponent<Rigidbody2D>().isKinematic = true;
	}
	void OnMouseDra(){
		//transform.Rotate(Vector3.up, -5 * Time.deltaTime);
		
        
        
	}
	void OnMouseDrag()
	{
		Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
		transform.position = cursorPosition;
		float r = radius * radius;
		Vector3 ff = new Vector3(gb.position.x, gb.position.y, gb.position.z);
		float y = ff.y;
		if( y > 5.0f)
			y = 5.0f;
		if( y < -1.0f)
			y = -1.0f;
		float y1 = y - 2.0f;
		float y2 = y1 * y1;
		float sq = r - y2;
		x = Mathf.Sqrt(sq) + .27f;
		Vector3 c = new Vector3(-x, y, 0.0f);
		transform.position  = c;
		DragOut = true;
		float yforce = 5 - y;
		 yforce = y * 100;
		Vector2 force = new Vector2 (100.0f,yforce);;
		
}
void OnMouseUp(){
	Debug.Log("mouse up");
		//rb.AddForce(force);
		//rb.AddForce(transform.forward * 8000.0f);
		SpringJoint2D name = GetComponent<SpringJoint2D>();
		name.enabled = false;
	}
	void Update(){
		if(DragOut == true){
		float r = radius * radius;
		Vector3 ff = new Vector3(gb.position.x, gb.position.y, gb.position.z);
		float y = ff.y;
		if( y > 2.0f + radius)
			y = 2.0f + radius;
		if( y < 2.0f - radius)
			y = 2.0f - radius;
		float y1 = y - 2.0f;
		float y2 = y1 * y1;
		float sq = r - y2;
		x = Mathf.Sqrt(sq) + .27f;
		Vector3 c = new Vector3(-x, y, 0.0f);
		transform.position  = c;
		if( y >= 5){
			DragOut = false;
			//SpringJoint2D name = GetComponent<SpringJoint2D>();
			//name.enabled = false;
		}
		}
	}

}