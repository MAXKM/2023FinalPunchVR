using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private AfterimageManager afterimageManager;
    [SerializeField] private AppearAfterimage appearAfterimage;
    [SerializeField] List<Vector3> posM = new List<Vector3>() { };
    [SerializeField] List<Quaternion> rotM = new List<Quaternion>() { };
    private int listCountP;
    private int listCountR;
    [SerializeField] float speed = 4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AfterImageCome();
        }
        //AfterImageGo();
    }

    public void AfterImageCome()
    {
        posM = afterimageManager.pos;
        rotM = afterimageManager.rot;
        listCountP = posM.Count;
        listCountR = rotM.Count;
        StartCoroutine(AA1(0));
        StartCoroutine(AA2(1));
        StartCoroutine(AA3(2));
        StartCoroutine(AA4(3));
        StartCoroutine(AA5(4));
        StartCoroutine(AAG1(6));
        StartCoroutine(AAG2(7));
        StartCoroutine(AAG3(8));
        StartCoroutine(AAG3(9));
        StartCoroutine(AAG4(10));
        StartCoroutine(AAG5(11));
        StartCoroutine(SM(15));
    }

    /*public void AfterImageGo()
    {
        StartCoroutine(AAG1(6));
        StartCoroutine(AAG2(7));
        StartCoroutine(AAG3(8));
        StartCoroutine(AAG3(9));
        StartCoroutine(AAG4(10));
        StartCoroutine(AAG5(11));
    }
    */


    IEnumerator AA1(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int i = 0; i <= 2; i++)
        {
            appearAfterimage.Appear(posM[i], rotM[i], false);
        }
    }
    IEnumerator AA2(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int j = 2; j <= 6; j++)
        {
            appearAfterimage.Appear(posM[j], rotM[j], false);
        }
    }
    IEnumerator AA3(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int k = 6; k <= 14; k++)
        {
            appearAfterimage.Appear(posM[k], rotM[k], false);
        }
    }
    IEnumerator AA4(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int l = 14; l <= 30; l++)
        {
            appearAfterimage.Appear(posM[l], rotM[l], false);
        }
    }
    IEnumerator AA5(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int m = 30; m <= listCountP; m++)
        {
            appearAfterimage.Appear(posM[m], rotM[m], false);
        }
    }

    IEnumerator AAG1(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int i = 0; i <= 2; i++)
        {
            //appearAfterimage.pool[i].transform.position = Vector3.MoveTowards(appearAfterimage.pool[i].transform.position, new Vector3(0, 0, 2), speed * Time.deltaTime);
            appearAfterimage.pool[i].transform.DOMove(new Vector3(0, 0, 2), 1);
            if (appearAfterimage.pool[i].transform.position == new Vector3(0, 0, 2)){
                appearAfterimage.pool[i].SetActive(false);
            }
        }
    }
    IEnumerator AAG2(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int j = 2; j <= 6; j++)
        {
            //appearAfterimage.pool[j].transform.position = Vector3.MoveTowards(appearAfterimage.pool[j].transform.position, new Vector3(0, 0, 2), speed * Time.deltaTime);
            appearAfterimage.pool[j].transform.DOMove(new Vector3(0, 0, 2), 1);
            if (appearAfterimage.pool[j].transform.position == new Vector3(0, 0, 2))
            {
                appearAfterimage.pool[j].SetActive(false);
            }
        }
    }
    IEnumerator AAG3(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int k = 6; k <= 14; k++)
        {
            //appearAfterimage.pool[k].transform.position = Vector3.MoveTowards(appearAfterimage.pool[k].transform.position, new Vector3(0, 0, 2), speed * Time.deltaTime);
            appearAfterimage.pool[k].transform.DOMove(new Vector3(0, 0, 2), 1);
            if (appearAfterimage.pool[k].transform.position == new Vector3(0, 0, 2))
            {
                appearAfterimage.pool[k].SetActive(false);
            }
        }
    }
    IEnumerator AAG4(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int l = 14; l <= 30; l++)
        {
            //appearAfterimage.pool[l].transform.position = Vector3.MoveTowards(appearAfterimage.pool[l].transform.position, new Vector3(0, 0, 2), speed * Time.deltaTime);
            appearAfterimage.pool[l].transform.DOMove(new Vector3(0, 0, 2), 1);
            if (appearAfterimage.pool[l].transform.position == new Vector3(0, 0, 2))
            {
                appearAfterimage.pool[l].SetActive(false);
            }
        }
    }
    IEnumerator AAG5(float wait)
    {
        yield return new WaitForSeconds(wait);
        for (int m = 30; m <= listCountP; m++)
        {
            //appearAfterimage.pool[m].transform.position = Vector3.MoveTowards(appearAfterimage.pool[m].transform.position, new Vector3(0, 0, 2), speed * Time.deltaTime);
            appearAfterimage.pool[m].transform.DOMove(new Vector3(0, 0, 2), 1);
            if (appearAfterimage.pool[m].transform.position == new Vector3(0, 0, 2))
            {
                appearAfterimage.pool[m].SetActive(false);
            }
        }
    }

    IEnumerator SM(float wait)
    {
        yield return new WaitForSeconds(wait);
        SceneManager.LoadScene("ResultScene");
    }
}
