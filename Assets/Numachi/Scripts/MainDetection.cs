using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDetection : MonoBehaviour
{
    private Vector3 mainHitPos; // メインの接触座標
    private Vector3 inFrontHitPos; // 手前の接触座標
    private Vector3 direction; // 残像の方向ベクトル

    [SerializeField] private AppearAfterimage appearAfterimage;
    private void OnTriggerEnter(Collider other)
    {
        if (inFrontHitPos == null) return;
        // メインの接触座標を取得
        mainHitPos = other.ClosestPoint(transform.position);
        direction = mainHitPos - inFrontHitPos;
        Quaternion targetRot = Quaternion.FromToRotation(transform.forward,direction);
        appearAfterimage.Appear(inFrontHitPos,targetRot);
    }

    public void SetInFrontPosition(Vector3 _pos)
    {
        inFrontHitPos = _pos;
    }
}
