using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleDetection : MonoBehaviour
{
    public GameManager gamemanager;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("当たった");
        //gamemanager.SetStase; 関数名はこれでOK？
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
