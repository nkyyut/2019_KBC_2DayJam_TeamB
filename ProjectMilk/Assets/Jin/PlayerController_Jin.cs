using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Jin : BasePlayer {

    EffectCreaterScript Effect;

	void Start () {
		base.PlayerSpeed = 200.0f;
        base.rigid2D = GetComponent<Rigidbody2D>();

        this.rigid2D.AddForce(new Vector2(0.0f,1) * base.PlayerSpeed);

        Effect = GetComponent<EffectCreaterScript>();

        base.ExplosionPower = 0.5f;

	}
	
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            //爆発エフェクト
            Effect.EfectCreate( this.transform.position,"Bomb" , base.GetExplosionPower());
            //Enemyのタグを持っているオブジェクトをすべて取得
            GameObject[] Enemys = GameObject.FindGameObjectsWithTag("Enemy");

            for(int i=0; i<Enemys.Length; i++)
            {
                EnemyController e = Enemys[i].gameObject.GetComponent<EnemyController>();
                //プレイヤーと敵の距離をそれぞれ取得
                float distance = (this.transform.position - e.transform.position).sqrMagnitude;              
                Debug.Log(distance);

                //距離　＜　爆発力
                if(distance < base.GetExplosionPower() * 3f)
                {
                    //ランダム方向に回転しながら吹っ飛ぶ
                    e.SmashEnemy();
                }
            }
            
            
            Destroy(this.gameObject);
        }

        if(col.tag == "Bomb")
        {
            base.SetExplosionPower(base.GetExplosionPower() + 0.5f);
        }
    }

}
