using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchScript : MonoBehaviour {

    AudioSource audio;
    AudioSource audio2;

    float Time = 0f;
    private bool SceneFlg = false;

	// Use this for initialization
	void Start () {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        audio = audioSources[0];
        audio2 = audioSources[1];
        audio2.Play();
    }
	
	// Update is called once per frame
	void Update () {
        if(SceneFlg == true)
             if (!audio.isPlaying)
                   SceneManager.LoadScene("Main");    //メインのシーン名を
    }
    public void OnClick()
    {
        audio.PlayOneShot(audio.clip);
        SceneFlg = true;
    }
}
