using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum STATE
    {
        TITLE, //�^�C�g��
        GAMESCENE, //�Q�[���V�[��
        RESULT, //���U���g
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStase(STATE state)
    {
        switch (state)
        {
            case STATE.TITLE:
               //UI�̕\��
                break;

            case STATE.GAMESCENE:
                //���Ԃ̌v���J�n�A�p���`�ŃJ�E���g�ł���悤�ɂ���
                break;

            case STATE.RESULT:
                //resultmanager�ɒʒm
                break;
        }
    }
}
