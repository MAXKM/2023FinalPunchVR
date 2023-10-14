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
    private void Start()
    {
        TitleUIAnim();
        DOVirtual.DelayedCall(3f,() =>
        {
            DisplayGameStateUI();
        });
    }

    public void TitleUIAnim()
    {
        titleTextTf.DOLocalMoveY(-1.7f, 0.5f).SetLoops(-1,LoopType.Yoyo);
    }

    public void DisplayGameStateUI()
    {
        // �^�C�g��UI���\��
        titleUI.DOFade(0,0.5f);
        // �Q�[������UI��\��
        timerText.SetActive(true);
        punchTextTf.DOScale(Vector3.one,1f);
        punchTextTf.GetComponent<CanvasGroup>().DOFade(1,0.7f);
    }
}
