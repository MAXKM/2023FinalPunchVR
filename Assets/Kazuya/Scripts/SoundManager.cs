using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource_Sound;
    [SerializeField] AudioSource audioSource_BGM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlaySound(AudioClip hitsound)
    {
        audioSource_Sound.PlayOneShot(hitsound);
    }

    public void PlayBGM(AudioClip BGM){
        audioSource_BGM.clip = BGM;
        audioSource_BGM.Play();
    }

    public void StopBGM()
    {
        audioSource_BGM.Stop();
    }

}
