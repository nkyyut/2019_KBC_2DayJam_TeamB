using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sprite : MonoBehaviour {

    public enum SpriteType // 画像数を加減する場合はこの列挙定数を変更してください
    {
        FIRST,
        SECOND,
        THIRD,
    }
    [SerializeField] private SpriteType MyType = SpriteType.FIRST; // 画像格納配列の添字

    [SerializeField] private Sprite[] sprites; // 画像を格納する配列(インスペクタで格納してください)

    private SpriteRenderer Sprd; // 自オブジェクトのコンポーネントへアクセスするための変数

    private void Awake()
    {
        Sprd = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Sprd.sprite = sprites[(int)MyType];
    }

    public void SetSprite(int type)// 1～N（N=2以上の自然数)をゼロベースに直し添字に代入
    {
        MyType = (SpriteType)type - 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MyType += 1;
        if((int)MyType >= sprites.Length)
        {
            MyType = 0;
        }
    }
}
