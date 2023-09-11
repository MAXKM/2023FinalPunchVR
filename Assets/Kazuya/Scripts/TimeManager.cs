using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private Text timerText; // §ŒÀŠÔ‚ğŠi”[‚·‚é•Ï”
    private float limit;

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
        limit -= Time.deltaTime;
        timerText.text = limit.ToString("0.00");

        if (limit < 0)
        {
            timerText.text = "ƒV[ƒ“‘JˆÚ";
            
        }
    }
}
