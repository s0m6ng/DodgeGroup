using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene04Dlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnStop = null;
    [SerializeField] Turret04[] m_TurretList = null;
    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_btnStop.onClick.AddListener(OnClicked_Stop);
    }

    private void OnClicked_Start()
    {
        for (int i = 0; i < m_TurretList.Length; i++)
        {
            m_TurretList[i].StartFire();
        }
    }

    private void OnClicked_Stop()
    {
        for (int i = 0; i < m_TurretList.Length; i++)
        {
            m_TurretList[i].StopFire();
        }
    }

}
