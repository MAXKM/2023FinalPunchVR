using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text StartObject;   

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
        //Debug.Log("�Փ˂���");
        Text StartText = StartObject.GetComponent<Text>();
        StartText.gameObject.SetActive(false);
    }
}
