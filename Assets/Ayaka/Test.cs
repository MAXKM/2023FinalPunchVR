using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test : MonoBehaviour
{
    //public Text StartObject;      //Text�p
    public GameObject StartObject;�@//TMPro�p

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    private void OnTriggerEnter(Collider other)
    {
        //Text�p
        //Text StartText = StartObject.GetComponent<Text>();

        //TMPro�p
        TextMeshProUGUI StartText = StartObject.GetComponent<TextMeshProUGUI>();
        StartText.gameObject.SetActive(false);
    }
}
