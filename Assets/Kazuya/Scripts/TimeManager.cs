using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText; // 制限時間を格納する変数
    [SerializeField] private float limit;
    public enum STATE { RESULT };
    [SerializeField] GameManager gameManager;
    private bool count;

    // Start is called before the first frame update
    void Start()
    {
        //limit = 30.0f;
        //timerText = GetComponent<Text>();
        timerText.text = "30.0";
    }

    // Update is called once per frame
    void Update()
    {
        if (count == true) 
        {
            limit -= Time.deltaTime;
            timerText.text = limit.ToString("0.00");
            if (limit < 0)
            {
                timerText.gameObject.SetActive(false);
                gameManager.SetState(GameManager.STATE.RESULT);
                count = false;
            }
        }
    }
    public void CountTime()
    {
        count = true;
    }
}
