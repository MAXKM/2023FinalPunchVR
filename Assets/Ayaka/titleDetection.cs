using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Meta.WitAi;

public class titleDetection : MonoBehaviour
{
    public GameManager gameManager;
    //public Text StartObject;      //Text�p
    public GameObject StartObject;�@//TMPro�p

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

        //�e�L�X�g�폜
        //Text�p
        //Text StartText = StartObject.GetComponent<Text>();

        //TMPro�p
        //TextMeshProUGUI StartText = StartObject.GetComponent<TextMeshProUGUI>();
        //StartText.gameObject.SetActive(false);

        // �ύX���܂����i�k�}�`�j
        //StartObject.SetActive(false);
        this.enabled = false;
    }
}
