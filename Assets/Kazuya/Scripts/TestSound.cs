using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    [SerializeField] SoundManager soundmanager; //本番ではmaindetectionに変更してください
    public void OnClick()
    {
        Debug.Log("sound");
        soundmanager.PlaySound();
    }
}
