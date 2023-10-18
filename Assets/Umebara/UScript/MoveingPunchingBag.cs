using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPunchingBag : MonoBehaviour
{
    public void KnockBack()
    {
        this.transform.DOMove(new Vector3(0f, 0f, 1.75f), 0.075f);
        this.transform.DORotate(new Vector3(45f, 0f, 0f), 0.075f);
        this.transform.DOMove(new Vector3(0f, 0f, 1.0f), 0.15f).SetDelay(0.075f);
        this.transform.DORotate(new Vector3(0f, 0f, 0f), 0.15f).SetDelay(0.075f);
    }

    public void ResultDirection()
    {
        this.transform.DOJump(new Vector3(0, 0, 7), 2.0f, 1, 1.5f);
        this.transform.DORotate(new Vector3(180f, 0f, 0f), 0.1875f).SetLoops(8,LoopType.Incremental);

        this.transform.DOMove(new Vector3(0f, 0f, 7.75f), 0.1f).SetDelay(1.5f);
        this.transform.DORotate(new Vector3(45.0f, 0f, 0f), 0.1f).SetDelay(1.5f);

        this.transform.DOMove(new Vector3(0f, 0f, 7.0f), 0.1f).SetDelay(1.6f);
        this.transform.DORotate(new Vector3(0f, 0f, 0f), 0.1f).SetDelay(1.6f);

        this.transform.DOMove(new Vector3(0f, 0f, 6.7f), 0.1f).SetDelay(1.7f);
        this.transform.DORotate(new Vector3(-22.5f, 0f, 0f), 0.1f).SetDelay(1.7f);

        this.transform.DOMove(new Vector3(0f, 0f, 7.0f), 0.1f).SetDelay(1.8f);
        this.transform.DORotate(new Vector3(0f, 0f, 0f), 0.1f).SetDelay(1.8f);
    }
    public void ResultDirection2()
    {
        this.transform.DOMove(new Vector3(0f, 6.7f, 15.8f), 1.5f);
        this.transform.DORotate(new Vector3(180f, 0f, 0f), 0.1875f).SetLoops(8, LoopType.Incremental);

        this.transform.DOMove(new Vector3(0f, 0f, 15.0f), 1.25f).SetDelay(1.6f).SetEase(Ease.InQuart);
        this.transform.DORotate(new Vector3(-45.0f, 0f, 0f), 1.25f).SetDelay(1.6f).SetEase(Ease.InQuart);

        this.transform.DOMove(new Vector3(0f, 0f, 15.75f), 0.25f).SetDelay(2.85f);
        this.transform.DORotate(new Vector3(0f, 0f, 0f), 0.25f).SetDelay(2.85f);

        this.transform.DOMove(new Vector3(0f, 0f, 16.005f), 0.25f).SetLoops(2, LoopType.Yoyo).SetDelay(3.1f);
        this.transform.DORotate(new Vector3(22.5f, 0f, 0), 0.25f).SetLoops(2, LoopType.Yoyo).SetDelay(3.1f);
    }
    public void ResultDirection3()
    {
        this.transform.DOMove(new Vector3(0f, 6.7f, 15.8f), 1.0f);
        this.transform.DORotate(new Vector3(180f, 0f, 0f), 0.125f).SetLoops(8, LoopType.Incremental);


        this.transform.DOMove(new Vector3(-17.65f, 2.95f, 1.45f), 1.0f).SetDelay(1.0f);
        this.transform.DORotate(new Vector3(180f, 90f, 0f), 0.125f).SetLoops(8, LoopType.Incremental).SetDelay(1.0f);

        this.transform.DOMove(new Vector3(11.9f, 14.0f, 7.8f), 1.0f).SetDelay(2.0f);
        this.transform.DORotate(new Vector3(90f, 0f, 90f), 0.111f).SetLoops(9, LoopType.Incremental).SetDelay(2.0f);

        this.transform.DOMove(new Vector3(6.63f, 3.41f, -15.91f), 1.0f).SetDelay(3.0f);
        this.transform.DORotate(new Vector3(180f, 45f, 90f), 0.111f).SetLoops(9, LoopType.Incremental).SetDelay(3.0f);
    }
}
