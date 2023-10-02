using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text StartText;

    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "StartText")
        //{
            StartText.gameObject.SetActive(false);
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        StartText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
