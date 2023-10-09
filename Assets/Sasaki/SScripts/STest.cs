using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class STest : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject StartObject;Å@//TMProóp

    void Start()
    {

    }
        private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaw");
        gameManager.SetState(GameManager.STATE.GAMESCENE);

        //TMProóp
        TextMeshProUGUI StartText = StartObject.GetComponent<TextMeshProUGUI>();
        StartText.gameObject.SetActive(false);
    }
}
