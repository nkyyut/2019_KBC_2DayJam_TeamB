using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMAudioManager : MonoBehaviour {

    AudioSource _audioSource;

    [SerializeField] AudioClip MainBGM;

	void Start () {
		_audioSource = this.GetComponent<AudioSource>();
        
	}
	
	void Update () {
		
	}

    public void StopMainBGM()
    {
        _audioSource.Stop();
    }


}
