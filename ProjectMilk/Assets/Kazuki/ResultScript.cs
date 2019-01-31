using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour {

    private int Test = 0;
    //表示する速さをInspectorで調節できるように
    [SerializeField] float FillSpeed = 0;

    public GameObject ScoreOb = null;
    public GameObject ImageOb = null;

    void Start () {
        
    }
	
	void Update () {

        if(Test == 0)
        {
            //スコアをここで入る
            //Test = 
        }

        //何か開始するflgがあったらいいのかな？
        //if()
        Text Score = ScoreOb.GetComponent<Text>();
        ImageOb.GetComponent<Image>().fillAmount += FillSpeed;

        if (ImageOb.GetComponent<Image>().fillAmount == 1f)
        Score.text = Test+"体";
        
	}
}
