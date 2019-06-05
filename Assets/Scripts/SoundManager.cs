using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    //COMPLETAR!

    public AudioClip hitPaleta;
    public AudioClip hitPared;
    public AudioClip winSnd;

    private AudioSource sfxAudio;

    // Use this for initialization
    void Start () {
		
	}
	
	void PlaySoundEffect(AudioClip clip)
    {
        sfxAudio.PlayOneShot(clip);
    }
}
