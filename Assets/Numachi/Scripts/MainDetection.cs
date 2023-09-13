using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDetection : MonoBehaviour
{
    private Vector3 mainHitPos; // ���C���̐ڐG���W
    private Vector3 inFrontHitPos; // ��O�̐ڐG���W
    private Vector3 direction; // �c���̕����x�N�g��

    [SerializeField] private AppearAfterimage appearAfterimage;
    private void OnTriggerEnter(Collider other)
    {
        if (inFrontHitPos == null) return;
        // ���C���̐ڐG���W���擾
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
