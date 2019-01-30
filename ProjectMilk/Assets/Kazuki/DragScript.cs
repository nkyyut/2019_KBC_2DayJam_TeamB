using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour {

    

    Vector2 TouchState;
    Vector2 TouchEnd;

    public bool flg = false;
	
	void Start () {
		
	}
	
	
	void Update () {

        GetTouch();
        
	}

    void GetTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch tch = Input.GetTouch(0);

            //画面をタッチしたとき
            if (tch.phase == TouchPhase.Began)
            {
                Debug.Log("押しました");
                TouchState = tch.position;
                Debug.Log(TouchState);
            }
            //画面から指を離したとき
            if (tch.phase == TouchPhase.Ended)
            {
                Debug.Log("離した");
                TouchEnd = tch.position;
                Debug.Log(TouchEnd);
                flg = true;
            }
        }
    }

    public Vector2  AngleChang()
    {
        float dx = TouchEnd.x - TouchState.x;
        float dy = TouchEnd.y - TouchState.y;
        Vector2 vec = new Vector2(-dx ,-dy);
        vec.Normalize();
        float rad = Mathf.Atan2(dx,dy);
        Debug.Log(vec);
        return vec;
    }
}
