using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamsObjects : MonoBehaviour
{
	Rigidbody rb;
	public float force;
    // Start is called before the first frame update
    void Start()
    {
	  rb = GetComponent<Rigidbody>();
        transform.Rotate(-90, 0, 0);
	  transform.position = new Vector3(transform.position.x, 10, 3);
    }

    // Update is called once per frame
    void Update()
    {
	    if(transform.position.y <= -37)
        {
	        Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
		rb.AddForce(transform.forward * -force);
    }
}
