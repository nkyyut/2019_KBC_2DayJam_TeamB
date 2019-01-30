﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectCreaterScript : MonoBehaviour {
    public string[] EffectKeyArray;
    public GameObject[] EffectGameObjectArray;
    public Dictionary<string, GameObject> Effect_Array=new Dictionary<string, GameObject>();
    Vector2 TestPos = new Vector2(0, 0);
	// Use this for initialization
	void Start () {
        for (int i=0; EffectKeyArray.Length>i;i++ )
        {
            Effect_Array.Add(EffectKeyArray[i],EffectGameObjectArray[i]);
        }
	}
	
	// Update is called once per fr
	void Update () {
        if(Input.GetMouseButtonUp(0)){
            EfectCreate(TestPos,"Bomb",0.5f);
        }
		
	}

    public void EfectCreate(Vector2 Pos,string Key,float EffectSize)
    {
        GameObject Go;
        Go = Instantiate(Effect_Array[Key])as GameObject;
        Go.transform.localScale = new Vector3(EffectSize,EffectSize,EffectSize);
    }
}
