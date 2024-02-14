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
    //[SerializeField] TextMeshProUGUI TitleText;   //�e�L�X�g
    [SerializeField] GameObject PObj;
    [SerializeField] UIManager uiManager;
    [SerializeField] GameObject Control;
    [SerializeField] AudioClip audioClipBgm;
    [SerializeField] AudioClip audioClipTitle;
    [SerializeField] AudioClip audioClipResult;
    [SerializeField] SoundManager soundManager;
    public bool SJudge = false;


    //�Ǘ�������
    public enum STATE
    {
        TITLE, //�^�C�g��
        //PRACTICE, //���K
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
    public void SetState(STATE _state)
    {
        switch (_state)
        {
            case STATE.TITLE:
                if (state == STATE.TITLE) return;
                state = STATE.TITLE;
                //Debug.Log("Title");
                //UI�̕\��
                //TitleText.gameObject.SetActive(true);     
                //TitleText.gameObject.SetActive(false);
                break;

            //case STATE.PRACTICE:
            //    Debug.Log("Practice");
            //    break;

            case STATE.GAMESCENE:
                if (state == STATE.GAMESCENE) return;
                state = STATE.GAMESCENE;
                //���Ԃ̌v���J�n
                //Debug.Log("Game");
                soundManager.StopBGM();
                Control.GetComponent<OVRPlayerController>().enabled = false;
                StartCoroutine(uiManager.DisplayGameStateUI(() =>
                {
                    SJudge = true;
                    timeManager.CountTime();
                    soundManager.PlaySound(audioClipTitle);
                    soundManager.PlayBGM(audioClipBgm);    //���y�ύX
                }));
                break;

            case STATE.RESULT:
                if (state == STATE.RESULT) return;
                state = STATE.RESULT;
                //Debug.Log("Result");
                soundManager.PlaySound(audioClipResult);
                PObj.SetActive(true);
                uiManager.DisplayStopText();
                resultManager.AfterImageCome();
                mainDetection.HandColliderOff();
                //resultmanager�ɒʒm
                break;
        }
    }
}
