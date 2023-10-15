using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Transform titleTextTf;
    [SerializeField] private CanvasGroup titleUI;

    [SerializeField] private GameObject timerText;
    [SerializeField] private Transform punchTextTf;

    [SerializeField] private Transform stopTextTf;
    private void Start()
    {
        TitleUIAnim();
    }

    public void TitleUIAnim()
    {
        titleTextTf.DOLocalMoveY(-1.7f, 0.5f).SetLoops(-1,LoopType.Yoyo);
    }

    public void DisplayGameStateUI()
    {
        // タイトルUIを非表示
        titleUI.DOFade(0,0.5f);
        // ゲーム中のUIを表示
        timerText.SetActive(true);
        punchTextTf.DOScale(Vector3.one,1f);
        punchTextTf.GetComponent<CanvasGroup>().DOFade(1,0.7f);
    }

    public void DisplayStopText()
    {
        punchTextTf.GetComponent<CanvasGroup>().DOFade(0,0.5f);
        stopTextTf.GetComponent<CanvasGroup>().DOFade(1,0.7f);
        stopTextTf.DOScale(Vector3.one,1f);
    }
}
