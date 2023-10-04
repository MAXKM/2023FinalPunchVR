using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDetection : MonoBehaviour
{
    private Vector3 mainHitPos; // ���C���̐ڐG���W
    private Vector3 inFrontHitPos; // ��O�̐ڐG���W
    private Vector3 direction; // �c���̕����x�N�g��
    [SerializeField] private AfterimageManager afterimageManager;
    [SerializeField] private AppearAfterimage appearAfterimage;
    [SerializeField] private Collider[] handCollider; // 0=>�� 1=>�E
    private titleDetection titleDetection;

    private void Start()
    {
        titleDetection = GetComponent<titleDetection>();
    }

    // �e�X�g�p
    [SerializeField] private bool isVRTest;
    private void OnTriggerEnter(Collider other)
    {
        if (inFrontHitPos == null) return;
        // ���C���̐ڐG���W���擾
        mainHitPos = other.ClosestPoint(transform.position);
        direction = mainHitPos - inFrontHitPos;
        Quaternion targetRot = Quaternion.FromToRotation(transform.forward,direction);
        appearAfterimage.Appear(inFrontHitPos,targetRot);
        // ���U���g�ɏo���c���͏�����납��\������
        inFrontHitPos.z -= 0.5f;
        afterimageManager.Store(inFrontHitPos,targetRot);
        if (!isVRTest) return; // �e�X�g�p�A��ŏ���
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
        if (titleDetection.enabled) titleDetection.enabled = false;
    }

    public void SetInFrontPosition(Vector3 _pos)
    {
        inFrontHitPos = _pos;
    }

    // �Q�[���I���㋭���I�ɉ���Ȃ�����
    public void HandColliderOff()
    {
        foreach (Collider collider in handCollider) 
            collider.enabled = false;
    }
}
