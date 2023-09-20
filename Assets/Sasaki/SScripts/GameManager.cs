using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //[SerializeField] TitleDetection titleDetection;
    [SerializeField] TimeManager timeManager;
    [SerializeField] MainDetection mainDetection;
    //[SerializeField] ResultManager resultManager;


    //管理する状態
    public enum STATE
    {
        TITLE, //タイトル
        GAMESCENE, //ゲームシーン
        RESULT, //リザルト
    }

    // Start is called before the first frame update
    void Start()
    {
        SetStase(STATE.TITLE);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //状態遷移を管理
    public void SetStase(STATE state)
    {
        switch (state)
        {
            case STATE.TITLE:
               //UIの表示
                break;

            case STATE.GAMESCENE:
                //時間の計測開始、パンチでカウントできるようにする＝maindetectionの有効化
                break;

            case STATE.RESULT:
                //resultmanagerに通知
                break;
        }
    }
}
