using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    [SerializeField] SoundManager soundmanager; //�{�Ԃł�maindetection�ɏ����Ă�������
    [SerializeField] AudioClip hitsound1; //���ʉ��̐��������₷
    [SerializeField] AudioClip hitsound2; //���ʉ��̐��������₷
    public void OnClick()
    {
        if (tag == "Sound1") 
        {
            soundmanager.PlaySound(hitsound1); //()�̒��g��ύX���邱�ƂŖ炷���ʉ����ς��
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
