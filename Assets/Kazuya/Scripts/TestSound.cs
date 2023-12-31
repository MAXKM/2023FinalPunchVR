using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    [SerializeField] SoundManager soundmanager; //本番ではmaindetectionに書いてください
    [SerializeField] AudioClip hitsound1; //効果音の数だけ増やす
    [SerializeField] AudioClip hitsound2; //効果音の数だけ増やす
    public void OnClick()
    {
        if (tag == "Sound1") 
        {
            soundmanager.PlaySound(hitsound1); //()の中身を変更することで鳴らす効果音が変わる
        }
        else if (tag == "Sound2")
        {
            soundmanager.PlaySound(hitsound2);
        }
    }
}
