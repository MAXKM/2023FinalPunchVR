using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Meta.WitAi;

public class titleDetection : MonoBehaviour
{
    public GameManager gameManager;
    //public Text StartObject;      //Text用
    public GameObject StartObject;　//TMPro用

    private int count = 0;
    [SerializeField] private UIManager UIManager;

    private void Start()
    {       
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
        UIManager.DisplayCountTextForPractice(10 - count);
        if (count < 10) return;
        gameManager.SetState(GameManager.STATE.GAMESCENE);

        //テキスト削除
        //Text用
        //Text StartText = StartObject.GetComponent<Text>();

        //TMPro用
        //TextMeshProUGUI StartText = StartObject.GetComponent<TextMeshProUGUI>();
        //StartText.gameObject.SetActive(false);

        // 変更しました（ヌマチ）
        //StartObject.SetActive(false);
        this.enabled = false;
    }
}
