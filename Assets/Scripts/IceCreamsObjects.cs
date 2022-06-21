using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamsObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(-90, 0, 0);
	  transform.position = new Vector3(transform.position.x,10,10f);
    }

    // Update is called once per frame
    void Update()
    {
	if(transform.position.y <= -37){
	Destroy(this.gameObject);
}
    }
}
