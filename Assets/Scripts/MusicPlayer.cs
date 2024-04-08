using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource[] audioSources;
    // Start is called before the first frame update
    void Start()
    {
        playBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playBGM() {
        audioSources = GetComponents<AudioSource>();
        audioSources[0].Play();
    }
    public void pauseBGM() {
        audioSources = GetComponents<AudioSource>();
        audioSources[0].Pause();
    }

}
