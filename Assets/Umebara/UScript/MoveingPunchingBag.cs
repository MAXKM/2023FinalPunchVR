using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPunchingBag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            KnockBack();
        }
    }

    void KnockBack()
    {
        this.transform.DOMove(new Vector3(0f, 0f, 0.075f), 0.075f).SetLoops(2, LoopType.Yoyo);
        this.transform.DORotate(new Vector3(278f, 0f, 0f), 0.075f).SetLoops(2, LoopType.Yoyo);
    }
}
