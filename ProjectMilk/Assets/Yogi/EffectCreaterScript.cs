using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectCreaterScript : MonoBehaviour {
    public string[] EffectKeyArray;
    public GameObject[] EffectGameObjectArray;
    public Dictionary<string, GameObject> Effect_Array=new Dictionary<string, GameObject>();
    Vector2 TestPos = new Vector2(0, 0);
	// Use this for initialization
	void Start () {
        for (int i=0; (i < 100) && (EffectKeyArray[i] != null);i++ )
        {
            Effect_Array.Add(EffectKeyArray[i],EffectGameObjectArray[i]);
        }
	}
	
	// Update is called once per fr
	void Update () {
        if(Input.GetMouseButtonUp(0)){
            EfectCreate(TestPos,"Bomb");
        }
		
	}

    void EfectCreate(Vector2 Pos,string Key)
    {
       
      Instantiate(Effect_Array[Key]);
                
    }
}
