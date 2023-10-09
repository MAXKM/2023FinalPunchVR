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
    [SerializeField] TextMeshProUGUI TitleText;   //テキスト


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
                //TitleText.gameObject.SetActive(true);     //使う
                //TitleText.gameObject.SetActive(false);
                break;

            case STATE.GAMESCENE:
                //時間の計測開始
                Debug.Log("Game");
                timeManager.CountTime();
                break;

            case STATE.RESULT:
                Debug.Log("Result");
                resultManager.AfterImageCome();
                mainDetection.HandColliderOff();
                //resultmanagerに通知
                break;
        }
    }
}
