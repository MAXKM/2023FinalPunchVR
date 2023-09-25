using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private Text timerText; // §ŒÀŠÔ‚ğŠi”[‚·‚é•Ï”
    private float limit;
    public enum STATE { RESULT };
    [SerializeField] GameManager gameManager;
    private bool count;

    // Start is called before the first frame update
    void Start()
    {
        limit = 30.0f;
        timerText = GetComponent<Text>();
        //timerText.text = "30.0";
    }

    // Update is called once per frame
    void Update()
    {
        if (count == true) 
        {
            Debug.Log(limit);
            limit -= Time.deltaTime;
            //timerText.text = limit.ToString("0.00");
            if (limit < 0)
            {
                Debug.Log("ppp");
                gameManager.SetState(GameManager.STATE.RESULT);
                count = false;
            }
        }
    }
    public void CountTime()
    {
        count = true;
        Debug.Log("time");
       

    }
}
