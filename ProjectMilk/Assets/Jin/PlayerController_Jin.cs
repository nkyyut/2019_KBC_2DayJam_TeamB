using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Jin : BasePlayer {

	void Start () {
		base.PlayerSpeed = 200.0f;
        base.rigid2D = GetComponent<Rigidbody2D>();

        this.rigid2D.AddForce(new Vector2(0,1) * base.PlayerSpeed);

	}
	
	void Update () {
		
	}
}
