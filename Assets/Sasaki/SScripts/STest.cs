using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class STest : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject StartObject;�@//TMPro�p

    void Start()
    {

    }
        private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaw");
        gameManager.SetState(GameManager.STATE.GAMESCENE);

        //TMPro�p
        TextMeshProUGUI StartText = StartObject.GetComponent<TextMeshProUGUI>();
        StartText.gameObject.SetActive(false);
    }
}
