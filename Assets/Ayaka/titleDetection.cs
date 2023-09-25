using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleDetection : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.SetState(GameManager.STATE.GAMESCENE);
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
