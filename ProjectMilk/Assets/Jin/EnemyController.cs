using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    Rigidbody2D rigid;

    private float   Smash_power     = 500.0f;
    private Vector3 Smash_powerDir  = Vector3.zero;
    private Vector3 Smash_offset    = Vector3.zero;

    

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Smash_offset.y = 1;
    }

    private void FixedUpdate()
    {

    }

    public void SmashEnemy()
    {
        //吹っ飛ばす方向をランダムで決定
        Smash_powerDir.y = Random.Range(-1.0f,1.0f);
        Smash_powerDir.x = Random.Range(-1.0f,1.0f);
        rigid.AddForceAtPosition( Smash_powerDir.normalized * Smash_power, transform.position + Smash_offset );
    }
}
