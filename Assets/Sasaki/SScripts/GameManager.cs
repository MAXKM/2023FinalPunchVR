using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum STATE
    {
        TITLE, //タイトル
        GAMESCENE, //ゲームシーン
        RESULT, //リザルト
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStase(STATE state)
    {
        switch (state)
        {
            case STATE.TITLE:
               //UIの表示
                break;

            case STATE.GAMESCENE:
                //時間の計測開始、パンチでカウントできるようにする
                break;

            case STATE.RESULT:
                //resultmanagerに通知
                break;
        }
    }
}
