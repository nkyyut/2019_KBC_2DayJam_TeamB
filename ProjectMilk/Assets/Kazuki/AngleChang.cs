using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleChang : MonoBehaviour {

    GameObject Dire;
    Vector3 vec3;
    bool flg = true;
    bool rotFlg = false;
    bool triger = true;
	// Use this for initialization
	void Start () {
        Dire = GameObject.Find("GameDirector");
	}
	
	// Update is called once per frame
	void Update () {
       
        rotFlg = Dire.GetComponent<DragScript>().flg2;
        if (rotFlg == true)
        {
            //押し始めた場所の位置(TouchState)と動かした後の位置(TouchEnd)を取得
            Vector3 vec1 = Dire.GetComponent<DragScript>().TouchState;
            Vector3 vec2 = Dire.GetComponent<DragScript>().TouchEnd;

            float dx = vec2.x - vec1.x;
            float dy = vec2.y - vec1.y;
            float rad = Mathf.Atan2(dy, dx);
            //Debug.Log(rad+"ラジアン");
            float deg = rad * Mathf.Rad2Deg;
            //Debug.Log(deg+"デッグ");
            Quaternion angle = this.transform.rotation;

            //deg+90の90足してるのはよくわからない？
            this.transform.rotation = Quaternion.Euler(angle.x,angle.y, deg+90f);

        }
    }
}
