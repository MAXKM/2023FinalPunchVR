using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleDetection : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("“–‚½‚Á‚½");
        gameManager.SetStase(GameManager.STATE.GAMESCENE);
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
