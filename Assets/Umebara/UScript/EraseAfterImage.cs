using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseAfterImage : MonoBehaviour
{
    GameObject[] punch;
    // Start is called before the first frame update
    void Start()
    {
        punch = GameObject.FindGameObjectsWithTag("PM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PM"))
        {
            StartCoroutine(EAA(0.5f));
            Debug.Log("a");
        }
    }

    IEnumerator EAA(float wait)
    {
        yield return new WaitForSeconds(wait);
        this.gameObject.SetActive(false);
    }
}
