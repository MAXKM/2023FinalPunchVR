using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    [SerializeField] SoundManager soundmanager; //–{”Ô‚Å‚Ímaindetection‚É•ÏX‚µ‚Ä‚­‚¾‚³‚¢
    public void OnClick()
    {
        Debug.Log("sound");
        soundmanager.PlaySound();
    }
}
