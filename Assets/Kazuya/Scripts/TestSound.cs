using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    [SerializeField] SoundManager soundmanager; //�{�Ԃł�maindetection�ɕύX���Ă�������
    public void OnClick()
    {
        Debug.Log("sound");
        soundmanager.PlaySound();
    }
}
