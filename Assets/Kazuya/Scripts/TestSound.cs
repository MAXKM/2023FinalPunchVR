using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    [SerializeField] SoundManager soundmanager; //�{�Ԃł�maindetection�ɕύX���Ă�������
    [SerializeField] AudioClip hitsound1;
    [SerializeField] AudioClip hitsound2;
    public void OnClick()
    {
        if (tag == "Sound1")
        {
            soundmanager.PlaySound(hitsound1);
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
