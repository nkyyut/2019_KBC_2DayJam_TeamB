using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResultScript : MonoBehaviour {

    public int SmashEnemyNum = 0;
    //表示する速さをInspectorで調節できるように
    [SerializeField] float FillSpeed = 0;

    public GameObject ScoreOb = null;
    public GameObject ImageOb = null;

    public bool IsResultFlg;//リザルト画面の描画フラグ

    void Start () {
        IsResultFlg = false;
    }
	
	void Update () {

        if (IsResultFlg)
        {
            Result();
        }

	}

    public void Result()
    {
        Text Score = ScoreOb.GetComponent<Text>();
        ImageOb.GetComponent<Image>().fillAmount += FillSpeed;

        if (ImageOb.GetComponent<Image>().fillAmount == 1f)
        Score.text = (SmashEnemyNum).ToString();
    }
}
