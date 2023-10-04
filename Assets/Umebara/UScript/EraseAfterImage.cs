using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseAfterImage : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    void Update()
    {
        if (this.transform.position.z >= 0.8f)
        {
            meshRenderer = this.GetComponentInChildren<MeshRenderer>();
            meshRenderer.enabled = false;
        }
    }
}
