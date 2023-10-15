using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDetection : MonoBehaviour
{
    private Vector3 mainHitPos; // ���C���̐ڐG���W
    private Vector3 inFrontHitPos; // ��O�̐ڐG���W
    private Vector3 direction; // �c���̕����x�N�g��
    private const float difference = 0.5f;
    private List<GameObject> hitEffectPool = new List<GameObject>(); // �q�b�g�G�t�F�N�g�̃��X�g�i�I�u�W�F�N�g�v�[���g�p�j
    [SerializeField] private AfterimageManager afterimageManager;
    [SerializeField] private AppearAfterimage appearAfterimage;
    [SerializeField] private Collider[] handCollider; // 0=>�� 1=>�E
    [SerializeField] private GameObject hitEffectPrefab; // �q�b�g�G�t�F�N�g�̃v���t�@�u

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

        // �q�b�g�G�t�F�N�g��\��
        GameObject hitEffect = GetHitEffectsFromPool(mainHitPos);
        if (!hitEffect.activeSelf) hitEffect.SetActive(true);

        // ���U���g�ɏo���c���͏�����납��\������
        //inFrontHitPos.z -= difference;
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
    }

    // ��O�̓����蔻����ꎞ�I�Ɋi�[
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

    // �q�b�g�G�t�F�N�g���v�[������擾
    private GameObject GetHitEffectsFromPool(Vector3 _pos)
    {
        for (int i = 0; i < hitEffectPool.Count; i++)
        {
            if (!hitEffectPool[i].activeSelf) return hitEffectPool[i];
        }
        GameObject newEffect = Instantiate(hitEffectPrefab,_pos,Quaternion.identity);
        hitEffectPool.Add(newEffect);
        return newEffect;
    }
}
