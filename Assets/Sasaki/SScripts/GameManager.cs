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
    //[SerializeField] TextMeshProUGUI TitleText;   //テキスト
    [SerializeField] GameObject PObj;
    [SerializeField] UIManager uiManager;
    [SerializeField] GameObject Control;
    [SerializeField] AudioClip audioClipBgm;
    [SerializeField] AudioClip audioClipTitle;
    [SerializeField] AudioClip audioClipResult;
    [SerializeField] SoundManager soundManager;
    public bool SJudge = false;


    //管理する状態
    public enum STATE
    {
        TITLE, //タイトル
        //PRACTICE, //練習
        GAMESCENE, //ゲームシーン
        RESULT, //リザルト
    }
    public STATE state;

    // Start is called before the first frame update
    void Start()
    {
        //初期状態をタイトル
        SetState(STATE.TITLE);
        //SetState(STATE.GAMESCENE);
    }

    //状態遷移を管理
    public void SetState(STATE _state)
    {
        switch (_state)
        {
            case STATE.TITLE:
                if (state == STATE.TITLE) return;
                state = STATE.TITLE;
                //Debug.Log("Title");
                //UIの表示
                //TitleText.gameObject.SetActive(true);     
                //TitleText.gameObject.SetActive(false);
                break;

            //case STATE.PRACTICE:
            //    Debug.Log("Practice");
            //    break;

            case STATE.GAMESCENE:
                if (state == STATE.GAMESCENE) return;
                state = STATE.GAMESCENE;
                //時間の計測開始
                //Debug.Log("Game");
                soundManager.StopBGM();
                Control.GetComponent<OVRPlayerController>().enabled = false;
                StartCoroutine(uiManager.DisplayGameStateUI(() =>
                {
                    SJudge = true;
                    timeManager.CountTime();
                    soundManager.PlaySound(audioClipTitle);
                    soundManager.PlayBGM(audioClipBgm);    //音楽変更
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
                //resultmanagerに通知
                break;
        }
    }
}
