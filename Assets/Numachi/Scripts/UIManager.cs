using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Transform countTextTf;

    [SerializeField] private Transform titleTextTf;
    [SerializeField] private CanvasGroup titleUI;

    [SerializeField] private GameObject timerText;
    [SerializeField] private Transform punchTextTf;

    [SerializeField] private Transform stopTextTf;

    [SerializeField] private CanvasGroup scoreTextCG;
    private void Start()
    {
        TitleUIAnim();
    }

    public void DisplayCountTextForPractice(int _count)
    {
        countText.text = _count.ToString();
        countTextTf.DOScale(Vector3.one * 1.5f, 0.1f).SetLoops(2, LoopType.Yoyo);
    }

    public void TitleUIAnim()
    {
        titleTextTf.DOLocalMoveY(-2.2f, 0.5f).SetLoops(-1,LoopType.Yoyo);
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
        punchTextTf.GetComponent<CanvasGroup>().DOFade(0,0.5f)
            .OnComplete(() => { punchTextTf.gameObject.SetActive(false); });
        stopTextTf.GetComponent<CanvasGroup>().DOFade(1,0.7f);
        stopTextTf.DOScale(Vector3.one,1f)
            .OnComplete(() => 
            {
                DOVirtual.DelayedCall(3f, () => {
                    stopTextTf.GetComponent<CanvasGroup>().DOFade(0, 1.5f); 
                });
            });
    }

    public void DisplayScoreText()
    {
        scoreTextCG.DOFade(1,0.5f);
    }
}
