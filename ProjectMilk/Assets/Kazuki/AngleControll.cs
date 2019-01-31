using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleControll : MonoBehaviour {

    GameObject ob;
    bool StateFlg;
	// Use this for initialization
	void Start () {
		ob = GameObject.Find("GameDirector");
	}
	
	// Update is called once per frame
	void Update () {
        
        StateFlg = ob.GetComponent<DragScript>().flg;


        //DragScriptのflg1がtureだった場合
        if (StateFlg == true)
        {
            StateFlg =false;
            //Vector2 posi = ob.GetComponent<DragScript>().VecChang();
            //transform.position += new Vector3(posi.x, posi.y);
        }
    }

}
