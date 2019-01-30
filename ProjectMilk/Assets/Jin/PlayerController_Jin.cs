using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Jin : BasePlayer {

    EffectCreaterScript Effect;

	void Start () {
		base.PlayerSpeed = 200.0f;
        base.rigid2D = GetComponent<Rigidbody2D>();

        this.rigid2D.AddForce(new Vector2(0,1) * base.PlayerSpeed);

        Effect = GetComponent<EffectCreaterScript>();

	}
	
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            Effect.EfectCreate( new Vector2(0,0),"Bomb" , 0.5f);

            GameObject[] Enemys = GameObject.FindGameObjectsWithTag("Enemy");

            for(int i=0; i<Enemys.Length; i++)
            {
                EnemyController e = Enemys[i].gameObject.GetComponent<EnemyController>();

                float distance = (this.transform.position - e.transform.position).sqrMagnitude;
                
                Debug.Log(distance);

                if(distance < 2)
                {
                    e.SmashEnemy();
                }
            }
            
            
            Destroy(this.gameObject);
        }
    }

}
