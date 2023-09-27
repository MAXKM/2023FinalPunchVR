using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    [SerializeField] SoundManager soundmanager; //–{”Ô‚Å‚Ímaindetection‚É‘‚¢‚Ä‚­‚¾‚³‚¢
    [SerializeField] AudioClip hitsound1; //Œø‰Ê‰¹‚Ì”‚¾‚¯‘‚â‚·
    [SerializeField] AudioClip hitsound2; //Œø‰Ê‰¹‚Ì”‚¾‚¯‘‚â‚·
    public void OnClick()
    {
        if (tag == "Sound1") 
        {
            soundmanager.PlaySound(hitsound1); //()‚Ì’†g‚ğ•ÏX‚·‚é‚±‚Æ‚Å–Â‚ç‚·Œø‰Ê‰¹‚ª•Ï‚í‚é
        }
        else if (tag == "Sound2")
        {
            soundmanager.PlaySound(hitsound2);
        }
        else
        {
            Debug.Log("MissSound");
        }
    }
}
