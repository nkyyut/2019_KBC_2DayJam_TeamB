﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    [SerializeField] string SceneName;

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void SceneChangeMesod()
    {
        SceneManager.LoadScene(SceneName);
    }

}
