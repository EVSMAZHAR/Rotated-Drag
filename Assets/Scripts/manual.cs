using UnityEngine;
 
public class manual : MonoBehaviour
{
    public GameObject orb;
    public float radius;
    public float radiusSpeed;
    public float rotationSpeed;
 
    private Transform centre;
    private Vector3 desiredPos;
 
    void Start()
    {
        centre = orb.transform;
        transform.position = (transform.position - centre.position).normalized * radius + centre.position;
    }
 
    void Update()
    {
        float rotationX = Input.GetAxis("Mouse X") * -rotationSpeed;
        transform.RotateAround(centre.position, Vector3.forward, rotationX);
 
        desiredPos = (transform.position - centre.position).normalized * radius + centre.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPos, radiusSpeed * Time.deltaTime);
    }
}