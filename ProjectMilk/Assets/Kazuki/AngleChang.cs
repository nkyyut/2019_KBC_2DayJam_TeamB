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
       
        rotFlg = Dire.GetComponent<DragScript2>().flg2;
        if (rotFlg == true)
        {

            Vector3 vec1 = Dire.GetComponent<DragScript2>().TouchState;
            Vector3 vec2 = Dire.GetComponent<DragScript2>().TouchEnd;

            float dx = vec2.x - vec1.x;
            float dy = vec2.y - vec1.y;
            float rad = Mathf.Atan2(dy, dx);
            Debug.Log(rad+"ラジアン");
            float deg = rad * Mathf.Rad2Deg;
            Debug.Log(deg+"デッグ");
            Quaternion angle = this.transform.rotation;

            
            this.transform.rotation = Quaternion.Euler(angle.x,angle.y, deg+90f);

        }
    }
}
