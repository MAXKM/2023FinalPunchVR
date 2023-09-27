using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDetection : MonoBehaviour
{
    private Vector3 mainHitPos; // メインの接触座標
    private Vector3 inFrontHitPos; // 手前の接触座標
    private Vector3 direction; // 残像の方向ベクトル
    [SerializeField] private AfterimageManager afterimageManager;
    [SerializeField] private AppearAfterimage appearAfterimage;
    [SerializeField] private Collider[] handCollider; // 0=>左 1=>右

    // テスト用
    [SerializeField] private bool isVRTest;
    private void OnTriggerEnter(Collider other)
    {
        if (inFrontHitPos == null) return;
        // メインの接触座標を取得
        mainHitPos = other.ClosestPoint(transform.position);
        direction = mainHitPos - inFrontHitPos;
        Quaternion targetRot = Quaternion.FromToRotation(transform.forward,direction);
        appearAfterimage.Appear(inFrontHitPos,targetRot);
        afterimageManager.Store(inFrontHitPos,targetRot);
        if (!isVRTest) return; // テスト用、後で消す
        if (other.CompareTag("LeftHand"))
        {
            handCollider[0].enabled = false;
            handCollider[1].enabled = true;
        }
        else
        {
            handCollider[0].enabled = true;
            handCollider[1].enabled = false;
        }
    }

    public void SetInFrontPosition(Vector3 _pos)
    {
        inFrontHitPos = _pos;
    }
}
