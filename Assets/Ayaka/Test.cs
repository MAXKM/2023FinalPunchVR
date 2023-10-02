using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test : MonoBehaviour
{
    //public Text StartObject;      //Text用
    public GameObject StartObject;　//TMPro用

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
        //Text用
        //Text StartText = StartObject.GetComponent<Text>();

        //TMPro用
        TextMeshProUGUI StartText = StartObject.GetComponent<TextMeshProUGUI>();
        StartText.gameObject.SetActive(false);
    }
}
