using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class ResultManager : MonoBehaviour
{
    [SerializeField] AfterimageManager afterimageManager;
    [SerializeField] AppearAfterimage appearAfterimage;
    [SerializeField] MoveingPunchingBag moveingPunching;
    [SerializeField] GameManager gameManager;
    [SerializeField] List<Vector3> posM = new List<Vector3>() { };
    [SerializeField] List<Quaternion> rotM = new List<Quaternion>() { };
    [SerializeField] TextMeshProUGUI score_text;
    [SerializeField] TextMeshProUGUI resultdotweenText;
    [SerializeField] int score;
    public GameObject pM;
    private int listCountP;
    private int listCountR;
    private float count;
    private float interval;
    private int caa;
    private bool isDefaultScale;
    [SerializeField] private Transform parent; // 残像の親オブジェクト
    private Vector3 baseDirection = new Vector3(0, 1, 0);
    private float angle;
    private GameObject[] handParent;

    void Start()
    {
        moveingPunching = pM.GetComponent<MoveingPunchingBag>();
        var score_text = GetComponent<TextMeshProUGUI>();
        var resultdotweenText = GetComponent<TextMeshProUGUI>();
        caa = 0;
        score = 0;
        isDefaultScale = true;
    }

    public void AfterImageCome()
    {
        posM = afterimageManager.pos;
        rotM = afterimageManager.rot;
        listCountP = posM.Count-1;
        listCountR = rotM.Count;
        count = 0.25f * listCountR;
        interval = count / listCountR;
        moveingPunching.enabled = true;
        handParent = new GameObject[listCountR];
        //handParent = appearAfterimage.pool[0].transform.GetChild(2).gameObject;
        StartCoroutine(AA1(0));
        StartCoroutine(AA2(1));
        StartCoroutine(AA3(2));
        StartCoroutine(AA4(3));
        StartCoroutine(AA5(4));
        StartCoroutine(AAM(5));
        //StartCoroutine(Onprefab(9));
        InvokeRepeating("FAA", 10, interval);
        InvokeRepeating("CallPunch", 10.25f, interval);
        InvokeRepeating("PunchCount", 10.25f, interval);
        Invoke("CallCancell", 10.5f + (0.25f * listCountP));
        StartCoroutine(ResultScore2(11.5f + count));
        StartCoroutine(SM(19.0f + count));
    }
    
    IEnumerator AA1(float wait)
    {
        yield return new WaitForSeconds(wait);
        if (listCountP >= 2)
        {
            for (int i = 0; i <= 2; i++)
            {
                appearAfterimage.Appear(posM[i], rotM[i], false);
            }
        }else if (listCountP < 2)
        {
            for (int i = 0; i <= listCountP; i++)
            {
                appearAfterimage.Appear(posM[i], rotM[i], false);
            }
        }
    }
    IEnumerator AA2(float wait)
    {
        yield return new WaitForSeconds(wait);
        if (listCountP >= 6)
        {
            for (int j = 3; j <= 6; j++)
            {
                appearAfterimage.Appear(posM[j], rotM[j], false);
            }
        }
        else if(listCountP >= 3 && listCountP < 6)
        {
            for (int j = 3; j <= listCountP; j++)
            {
                appearAfterimage.Appear(posM[j], rotM[j], false);
            }
        }
    }
    IEnumerator AA3(float wait)
    {
        yield return new WaitForSeconds(wait);
        if (listCountP >= 14)
        {
            for (int k = 7; k <= 14; k++)
            {
                appearAfterimage.Appear(posM[k], rotM[k], false);
            }
        }else if(listCountP >= 7 && listCountP < 14)
        {
            for (int k = 7; k <= listCountP; k++)
            {
                appearAfterimage.Appear(posM[k], rotM[k], false);
            }
        }
    }
    IEnumerator AA4(float wait)
    {
        yield return new WaitForSeconds(wait);
        if (listCountP >= 30)
        {
            for (int l = 15; l <= 30; l++)
            {
                appearAfterimage.Appear(posM[l], rotM[l], false);
            }
        }else if (listCountP >= 15 && listCountP < 30)
        {
            for (int l = 15; l <= listCountP; l++)
            {
                appearAfterimage.Appear(posM[l], rotM[l], false);
            }
        }
    }
    IEnumerator AA5(float wait)
    {
        yield return new WaitForSeconds(wait);
        if (listCountP >= 31)
        {
            for (int m = 31; m <= listCountP; m++)
            {
                appearAfterimage.Appear(posM[m], rotM[m], false);
            }
        }
    }

    IEnumerator AAM(float wait)
    {
        yield return new WaitForSeconds(wait);
        angle = 360f / parent.childCount;
        for (int i = 0; i < parent.childCount; i++)
        {
            parent.GetChild(i).DOMove(Quaternion.Euler(0, 0, angle * i) * baseDirection, 3f);
        }
    }


    IEnumerator SM(float wait)
    {
        yield return new WaitForSeconds(wait);
        gameManager.SetState(GameManager.STATE.TITLE);
        SceneManager.LoadScene("Game");
    }

    private void FAA()
    {
        if (listCountP >= caa)
        {
            appearAfterimage.pool[caa].transform.DOMove(new Vector3(0, 0, 1), 0.25f);
            caa++;
        }
    }

    private void PunchCount()
    {
        if (listCountP >= score)
        {
            score++;
            score_text.text = score.ToString();
            score_text.transform.DOScale(new Vector3(0.005f, 0.005f, 0.005f), 0.05f);
            score_text.transform.DOScale(new Vector3(0.003f, 0.003f, 0.003f), 0.1f).SetDelay(0.05f);
        }
    }

    IEnumerator ResultScore2(float wait)
    {
        yield return new WaitForSeconds(wait);
        if (isDefaultScale)
        {
            resultdotweenText.text = score.ToString();
            resultdotweenText.transform.DOScale(new Vector3(0.01f, 0.01f, 0.01f), 0.5f);
            resultdotweenText.transform.DOScale(new Vector3(0.006f, 0.006f, 0.006f), 0.75f).SetDelay(0.50f);
            isDefaultScale = false;
        }
    }
    private void CallPunch()
    {
        moveingPunching.KnockBack();
    }

    /*IEnumerator Onprefab(float wait)
    {
        yield return new WaitForSeconds(wait);
        for(int n=0;n<= listCountP; listCountP++)
        {
            //handParent[n].SetActive(true);
        }
    }*/

    private void CallCancell()
    {
        CancelInvoke("CallPunch");
    }
}
