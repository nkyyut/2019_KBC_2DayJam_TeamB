using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLCon_shota : BasePlayer
{
    EffectCreaterScript Effect;
    [SerializeField] Vector2 myVec;
    public float plspd = 200.0f;

    void Start()
    {
        //base.PlayerSpeed = 200.0f;
        base.rigid2D = GetComponent<Rigidbody2D>();
        Effect = GetComponent<EffectCreaterScript>();
        base.ExplosionPower = 0.5f;
        this.rigid2D.AddForce(myVec * plspd);

    }

    void Update()
    {
        //transform.Translate(myVec * Time.deltaTime, 0);


        /* 進行方向を赤棒で示す（Sceneタブのみで目視可能） */
        Debug.DrawLine(gameObject.transform.position, gameObject.transform.position + new Vector3(myVec.x, myVec.y, 0),Color.red);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            //爆発エフェクト
            Effect.EfectCreate(this.transform.position, "Bomb", base.GetExplosionPower());
            //Enemyのタグを持っているオブジェクトをすべて取得
            GameObject[] Enemys = GameObject.FindGameObjectsWithTag("Enemy");

            for (int i = 0; i < Enemys.Length; i++)
            {
                EnemyController e = Enemys[i].gameObject.GetComponent<EnemyController>();
                //プレイヤーと敵の距離をそれぞれ取得
                float distance = (this.transform.position - e.transform.position).sqrMagnitude;
                Debug.Log(distance);

                //距離　＜　爆発力
                if (distance < base.GetExplosionPower() * 3f)
                {
                    //ランダム方向に回転しながら吹っ飛ぶ
                    e.SmashEnemy();
                }
            }


            Destroy(this.gameObject);
        }

        if (col.tag == "Bomb")
        {
            base.SetExplosionPower(base.GetExplosionPower() + 0.5f);
        }
    }

    public void SetVec(Vector2 v)
    {
        myVec = v;
    }

    public Vector2 GetVec()
    {
        return myVec;
    }
}
