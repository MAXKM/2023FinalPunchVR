using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseAfterImage : MonoBehaviour
{
    GameObject[] punch;
    //[SerializeField] private AppearAfterimage appearAfterimage;
    //[SerializeField] private ResultManager resultManager;
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        punch = GameObject.FindGameObjectsWithTag("PM");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z >= 0.8f)
        {
            meshRenderer = this.GetComponentInChildren<MeshRenderer>();
            meshRenderer.enabled = false;
            Debug.Log("abc");
            //appearAfterimage.pool[caa].SetActive(false);
        }
    }

    /*private void OnTriggerEnter(Collider other)
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
    }*/
}
