using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titleDetection : MonoBehaviour
{
    public GameManager gameManager;
    public Text StartObject;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.SetState(GameManager.STATE.GAMESCENE);

        //テキスト削除
        Text StartText = StartObject.GetComponent<Text>();
        StartText.gameObject.SetActive(false);
    }
}
