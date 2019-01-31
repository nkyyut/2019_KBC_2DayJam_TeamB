using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleControll : MonoBehaviour {


    bool StateFlg;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject ob = GameObject.Find("GameDirector");
        StateFlg = ob.GetComponent<DragScript>().flg;


        //DragScriptのflg2がtureだった場合
        if (StateFlg == true)
        {

            Vector2 posi = ob.GetComponent<DragScript>().VecChang();
            transform.position += new Vector3(posi.x, posi.y);
        }
    }

}
