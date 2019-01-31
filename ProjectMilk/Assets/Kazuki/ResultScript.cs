using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResultScript : MonoBehaviour {

    [SerializeField] BGMAudioManager BGM_Manager;
    public GameObject _audioSources_Drum;//ドラムロール
    public GameObject _audioSources_Drum_Finish;//ドラムロールフィニッシュ
    [SerializeField] GameObject RetryButton;
    [SerializeField] GameObject TitleButton;

    public int SmashEnemyNum = 0;
    //表示する速さをInspectorで調節できるように
    [SerializeField] float FillSpeed = 0;

    public GameObject ScoreOb = null;
    public GameObject ImageOb = null;

    public bool IsResultFlg;//リザルト画面の描画フラグ
    bool IsResultBGMFlg;//１回だけ処理するためのフラグ

    

    void Start () {
        IsResultFlg = false;
        IsResultBGMFlg = false;//１回だけ処理させる用
        BGM_Manager = BGM_Manager.GetComponent<BGMAudioManager>();
    }
	
	void Update () {

        if (IsResultFlg)
        {
            //メインBGMストップ
            BGM_Manager.StopMainBGM();
            
            Invoke("Result",1.0f);
                //１回だけ処理
            if (!IsResultBGMFlg)
            {
                Invoke("DrumRoolFinish", 2.5f);
                Invoke("ButtonOn", 2.7f);
            }
        }

	}

    public void Result()
    {
        //１回だけ処理
        if (!IsResultBGMFlg)
        {
            _audioSources_Drum.gameObject.GetComponent<AudioSource>().enabled = true;//ドラムロール再生
            
            IsResultBGMFlg = true;
        }     

        Text Score = ScoreOb.GetComponent<Text>();
        ImageOb.GetComponent<Image>().fillAmount += FillSpeed;

        if (ImageOb.GetComponent<Image>().fillAmount == 1f)
        Score.text = (SmashEnemyNum).ToString();
    }
    //ドラムロールフィニッシュを再生
    void DrumRoolFinish()
    {
        _audioSources_Drum.gameObject.GetComponent<AudioSource>().enabled = false;
        _audioSources_Drum_Finish.gameObject.GetComponent<AudioSource>().enabled = true;       
    }

    void ButtonOn()
    {
        RetryButton.SetActive(true);//リトライボタンを表示
        TitleButton.SetActive(true);//タイトルへのボタンを表示
    }
}
