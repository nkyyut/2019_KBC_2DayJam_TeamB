using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Jin : BasePlayer {

    EffectCreaterScript Effect;

	void Start () {       
		//base.PlayerSpeed = 200.0f;//仮のプレイヤースピード（一定）
        base.rigid2D = GetComponent<Rigidbody2D>();
        //this.rigid2D.AddForce(new Vector2(0.0f,1) * base.PlayerSpeed);
        Effect = GetComponent<EffectCreaterScript>();
        base.ExplosionPower = 0.5f;

	}
	
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            
            Effect.EfectCreate( this.transform.position,"Bomb" , base.GetExplosionPower());//爆発エフェクト
            
            GameObject[] Enemys = GameObject.FindGameObjectsWithTag("Enemy");//Enemyのタグを持っているオブジェクトをすべて取得
            
            for(int i=0; i<Enemys.Length; i++)
            {
                EnemyController e = Enemys[i].gameObject.GetComponent<EnemyController>();
                
                float distance = (this.transform.position - e.transform.position).sqrMagnitude;//プレイヤーと敵の距離をそれぞれ取得              
                Debug.Log(distance);

                //距離　＜　爆発力の場合
                if(distance < base.GetExplosionPower() * 3f)
                {                  
                    e.SmashEnemy();//ランダム方向に回転しながら吹っ飛ぶ
                }
            }
                      
            Destroy(this.gameObject);
        }
        //ひっつき虫取得による爆発力増加
        if(col.tag == "Bomb")
        {
            base.SetExplosionPower(base.GetExplosionPower() + 0.5f);
        }
    }

}
