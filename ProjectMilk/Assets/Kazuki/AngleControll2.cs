using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleControll2 : MonoBehaviour {

    bool flg2;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject ob = GameObject.Find("GameDirector");
        flg2 = ob.GetComponent<DragScript2>().flg;


        //DragScriptのflg2がtureだった場合
        if (flg2 == true)
        {
            Vector2 posi = ob.GetComponent<DragScript2>().AngleChang();
            transform.position += new Vector3(posi.x, posi.y);
        }


    }
}
