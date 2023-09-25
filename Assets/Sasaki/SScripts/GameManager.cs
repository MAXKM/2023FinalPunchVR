using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //[SerializeField] TitleDetection titleDetection;
    [SerializeField] TimeManager timeManager;
    [SerializeField] MainDetection mainDetection;
    //[SerializeField] ResultManager resultManager;


    //�Ǘ�������
    public enum STATE
    {
        TITLE, //�^�C�g��
        GAMESCENE, //�Q�[���V�[��
        RESULT, //���U���g
    }

    // Start is called before the first frame update
    void Start()
    {
        SetState(STATE.TITLE);
        //SetState(STATE.GAMESCENE);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //��ԑJ�ڂ��Ǘ�
    public void SetState(STATE state)
    {
        switch (state)
        {
            case STATE.TITLE:
               //UI�̕\���� titlscene�ɒʒm
                break;

            case STATE.GAMESCENE:
                //���Ԃ̌v���J�n�A�p���`�ŃJ�E���g�ł���悤�ɂ��遁maindetection�̗L����
                Debug.Log("Game");
                timeManager.CountTime();
                break;

            case STATE.RESULT:
                Debug.Log("re");
                //resultmanager�ɒʒm
                break;
        }
    }
}
