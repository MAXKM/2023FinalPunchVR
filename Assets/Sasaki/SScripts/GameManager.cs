using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //[SerializeField] TitleDetection titleDetection;
    [SerializeField] TimeManager timeManager;
    [SerializeField] MainDetection mainDetection;
    [SerializeField] ResultManager resultManager;
    [SerializeField] TextMeshProUGUI TitleText;   //�e�L�X�g


    //�Ǘ�������
    public enum STATE
    {
        TITLE, //�^�C�g��
        GAMESCENE, //�Q�[���V�[��
        RESULT, //���U���g
    }
    public STATE state;

    // Start is called before the first frame update
    void Start()
    {
        //������Ԃ��^�C�g��
        SetState(STATE.TITLE);
        //SetState(STATE.GAMESCENE);
    }

    //��ԑJ�ڂ��Ǘ�
    public void SetState(STATE state)
    {
        switch (state)
        {
            case STATE.TITLE:
                Debug.Log("Title");
                //UI�̕\��
                //TitleText.gameObject.SetActive(true);     //�g��
                //TitleText.gameObject.SetActive(false);
                break;

            case STATE.GAMESCENE:
                //���Ԃ̌v���J�n
                Debug.Log("Game");
                timeManager.CountTime();
                break;

            case STATE.RESULT:
                Debug.Log("Result");
                resultManager.AfterImageCome();
                mainDetection.HandColliderOff();
                //resultmanager�ɒʒm
                break;
        }
    }
}
