using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Jin : BasePlayer {

    EffectCreaterScript Effect;
    GameObject ResultManager;
    ResultScript ResultManagerScript;

    [SerializeField] Vector2 myVec;
    [SerializeField] float Speed;
    bool StateFlg;
    GameObject ob;

	void Start () {       
        base.rigid2D = GetComponent<Rigidbody2D>();
        ob = GameObject.Find("GameDirector");
        ResultManager = GameObject.Find("ResultManager");
        ResultManagerScript = ResultManager.GetComponent<ResultScript>();
        Effect = GetComponent<EffectCreaterScript>();
		//base.PlayerSpeed = 200.0f;//仮のプレイヤースピード（一定）
        base.SetPlayerSpeed(Speed);
        base.ExplosionPower = 0.5f;//初期爆発力

	}
	
	void Update () {
        StateFlg = ob.GetComponent<DragScript>().flg;

        //DragScriptのflg1がtureだった場合
        if (StateFlg)
        {            
            //矢印方向のベクトルを取得
            myVec = ob.GetComponent<DragScript>().VecChang();

            ob.GetComponent<DragScript>().flg = false;
            
        }

        //if (this.transform.position.x != 0)
        //    ob.GetComponent<DragScript>().flg = true;

        transform.Translate(myVec * Time.deltaTime * base.GetPlayerSpeed(), 0);//MyVecの方向に移動

		/* 進行方向を赤棒で示す（Sceneタブのみで目視可能） */
        Debug.DrawLine(gameObject.transform.position, gameObject.transform.position + new Vector3(myVec.x, myVec.y, 0),Color.red);


        //画面外に出たらリザルト画面を出してプレイヤーをデストロイ
        if(this.transform.position.x < -3.11f){
            ResultManagerScript.IsResultFlg = true;
            Destroy(this.gameObject);            
        }
        if(this.transform.position.x > 3.13f){
            ResultManagerScript.IsResultFlg = true;
            Destroy(this.gameObject);           
        }
        if(this.transform.position.y < -5.3f){
            ResultManagerScript.IsResultFlg = true;
            Destroy(this.gameObject);            
        }
        if(this.transform.position.y > 5.32f){
            ResultManagerScript.IsResultFlg = true;
            Destroy(this.gameObject);          
        }

	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        //敵に当たったとき爆発する
        if(col.tag == "Enemy")
        {
            
            Effect.EfectCreate( this.transform.position,"Bomb" , base.GetExplosionPower());//爆発エフェクト
            
            GameObject[] Enemys = GameObject.FindGameObjectsWithTag("Enemy");//Enemyのタグを持っているオブジェクトをすべて取得
            //敵の数だけまわす
            for(int i=0; i<Enemys.Length; i++)
            {
                EnemyController e = Enemys[i].gameObject.GetComponent<EnemyController>();
                
                float distance = (this.transform.position - e.transform.position).sqrMagnitude;//プレイヤーと敵の距離をそれぞれ取得              
                //Debug.Log(distance);

                //距離　＜　爆発力の場合
                if(distance < base.GetExplosionPower() * 3f)
                {                  
                    e.SmashEnemy();//ランダム方向に回転しながら吹っ飛ぶ
                    
                    ResultManagerScript.SmashEnemyNum++;//倒した敵の数をプラス
                }
            }
            
            ResultManagerScript.IsResultFlg = true;//リザルト画面を表示

            Destroy(this.gameObject);//自身をデストロイ
        }
        //ひっつき虫取得による爆発力増加
        if(col.tag == "Bomb")
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
