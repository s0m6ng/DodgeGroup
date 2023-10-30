using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene05Dlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Countdown05Dlg m_CountdownDlg = null;
    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_CountdownDlg.gameObject.SetActive(false);
    }

    private void OnClicked_Start()
    {
        m_CountdownDlg.gameObject.SetActive(true);
        m_CountdownDlg.Initialize();
    }
}
