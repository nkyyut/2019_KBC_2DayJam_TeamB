using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public enum SpriteType // 画像数を加減する場合はこの列挙定数を変更してください
    {
        FIRST,
        SECOND,
    }
    [SerializeField] private SpriteType MyType = SpriteType.FIRST; // 画像格納配列の添字

    [SerializeField] private Sprite[] sprites; // 画像を格納する配列(インスペクタで格納してください)

    private SpriteRenderer Sprd; // 自オブジェクトのコンポーネントへアクセスするための変数

    Rigidbody2D rigid;

    private float   Smash_power     = 500.0f;
    private Vector3 Smash_powerDir  = Vector3.zero;
    private Vector3 Smash_offset    = Vector3.zero;

    

    private void Start()
    {
        Sprd = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        Smash_offset.y = 1;
    }

    private void Update()
    {
        if(this.transform.position.x < -3.11f)Destroy(this.gameObject);
        if(this.transform.position.x > 3.13f)Destroy(this.gameObject);
        if(this.transform.position.y < -5.3f)Destroy(this.gameObject);
        if(this.transform.position.y > 5.32f)Destroy(this.gameObject);
        
        Sprd.sprite = sprites[(int)MyType];
    }

    public void SetSprite(int type)// 1～N（N=2以上の自然数)をゼロベースに直し添字に代入
    {
        MyType = (SpriteType)type - 1;
    }

    public void SmashEnemy()
    {
        //吹っ飛ばす方向をランダムで決定
        Smash_powerDir.y = Random.Range(-1.0f, 1.0f);
        Smash_powerDir.x = Random.Range(-1.0f, 1.0f);
        rigid.AddForceAtPosition( Smash_powerDir.normalized * Smash_power, transform.position + Smash_offset );

        MyType++;
        if((int)MyType >= sprites.Length)
        {
            MyType = 0;
        }
    }
}
