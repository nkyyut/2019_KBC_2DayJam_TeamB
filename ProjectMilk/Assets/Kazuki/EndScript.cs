using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour {

    AudioSource audio;
    private bool EndFlg = false;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (EndFlg == true)
            if (!audio.isPlaying)
                UnityEditor.EditorApplication.isPlaying = false;
                 Application.Quit();
    }
    public void OnClick()
    {
        audio = gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot(audio.clip);
        EndFlg = true;
        
    }
}
