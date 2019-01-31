using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour {

    public GameObject Player;

    public Vector3 TouchState;
    public Vector3 TouchEnd;

    public bool flg = false;
    public bool flg2 = false;

    public bool NoTouchFlg = false;
    
	void Start () {
		
	}
	
	
	void Update () {
        if(!NoTouchFlg)
            GetTouch();
    }

    void GetTouch()
    {
        //画面をタッチしたとき
        if (Input.GetMouseButtonDown(0))
        {
            TouchState = Input.mousePosition;

        }
        //画面から指を離したとき
        if (Input.GetMouseButtonUp(0))
        {
            TouchEnd = Input.mousePosition;
            flg = true;
            flg2 = false;
            NoTouchFlg = true;
            Player.SetActive(false);
        }
        //画面に触れてる間
        if (Input.GetMouseButton(0))
        {
            TouchEnd = Input.mousePosition;
            flg2 = true;
            if (TouchState != TouchEnd)    Player.SetActive(true);
        }
    }

    public Vector2  VecChang()
    {
        float dx = TouchEnd.x - TouchState.x;
        float dy = TouchEnd.y - TouchState.y;
        Vector2 vec = new Vector2(-dx ,-dy);
        vec.Normalize();
        //Debug.Log(vec);

        //Vector2型を返しているよ
        return vec;
    }
}
