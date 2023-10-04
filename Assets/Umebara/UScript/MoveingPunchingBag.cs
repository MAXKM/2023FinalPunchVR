using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPunchingBag : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            KnockBack();
        }
    }
    public void KnockBack()
    {
        this.transform.DOMove(new Vector3(0f, 0f, 1.75f), 0.075f).SetLoops(2, LoopType.Yoyo);
        this.transform.DORotate(new Vector3(45f, 0f, 0f), 0.075f).SetLoops(2, LoopType.Yoyo);
    }
}
