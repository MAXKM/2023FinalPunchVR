using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterimageTest : MonoBehaviour
{
    [SerializeField] private Transform parent; // 残像の親オブジェクト
    private Vector3 baseDorection = new Vector3(0, 5, 0);
    private float angle;

    private void Start()
    {
        angle = 360f / parent.childCount;
        for(int i = 0;i < parent.childCount; i++)
        {
            parent.GetChild(i).DOMove(Quaternion.Euler(0, 0, angle * i) * baseDorection,3f);
        }
    }
}
