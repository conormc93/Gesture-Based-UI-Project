using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioManager audioManager = null;
    public AudioClip laserBlast;
    public AudioClip splashScreen;
    public AudioClip powerUp;
    public AudioClip alienBlast;
    public AudioClip playerDeath;

    private AudioSource soundEffect;

    // Use this for initialization
    void Start () {
		if(audioManager == null){

            audioManager = this;
        }else if(audioManager != this){

            Destroy(gameObject);
        }
        AudioSource source = GetComponent<AudioSource>();
        soundEffect = source;
	}

    public void PlayOneShot(AudioClip clip){

        soundEffect.PlayOneShot(clip);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
