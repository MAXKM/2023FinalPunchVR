using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private Text timerText; // �������Ԃ��i�[����ϐ�
    private float limit;
    public enum STATE { RESULT };
    [SerializeField] GameManager;
    private bool count;

    // Start is called before the first frame update
    void Start()
    {
        limit = 30.0f;
        timerText = GetComponent<Text>();
        timerText.text = "30.0";
    }

    // Update is called once per frame
    void Update()
    {
        if (count == true) 
        {
            limit -= Time.deltaTime;
            timerText.text = limit.ToString("0.00");
        }
    }
    public void CountTime()
    {
        count = true;

        if (limit < 0)
        {
            gameManager.SetState(GameManager.STATE.RESULT);
            count = false;
        }

    }
}
