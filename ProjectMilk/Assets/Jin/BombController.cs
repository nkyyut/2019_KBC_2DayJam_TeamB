using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            //Destroy(this.gameObject);
            this.transform.parent = col.transform;
            this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        }
            
    }
}
