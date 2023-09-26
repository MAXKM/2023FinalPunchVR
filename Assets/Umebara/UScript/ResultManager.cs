using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private AfterimageManager afterimageManager;
    [SerializeField] private AppearAfterimage appearAfterimage;
    [SerializeField] List<Vector3> posM = new List<Vector3>() { };
    [SerializeField] List<Quaternion> rotM = new List<Quaternion>() { };
    private int listCountP;
    private int listCountR;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AfterImageCome();
            Debug.Log(listCountR);
        }
    }

    public void AfterImageCome()
    {
        posM = afterimageManager.pos;
        rotM = afterimageManager.rot;
        listCountP = posM.Count;
        listCountR = rotM.Count;
        for (int i = 0; i <= listCountP; i++)
        {
            appearAfterimage.Appear(posM[i], rotM[i]);
        }
    }
}
