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


    //管理する状態
    public enum STATE
    {
        TITLE, //タイトル
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
    public void SetState(STATE state)
    {
        switch (state)
        {
            case STATE.TITLE:
                Debug.Log("Title");
                //UIの表示
                //TitleText.gameObject.SetActive(true);     
                //TitleText.gameObject.SetActive(false);
                break;

            case STATE.GAMESCENE:
                //時間の計測開始
                Debug.Log("Game");
                uiManager.DisplayGameStateUI();
                timeManager.CountTime();
                break;

            case STATE.RESULT:
                Debug.Log("Result");
                PObj.SetActive(true);
                uiManager.DisplayStopText();
                resultManager.AfterImageCome();
                mainDetection.HandColliderOff();
                //resultmanagerに通知
                break;
        }
    }
}
