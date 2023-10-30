using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameScene03Dlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnStop = null;
    [SerializeField] Turret03 m_Turret = null;
    bool m_IsFire = false;
    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_btnStop.onClick.AddListener(OnClicked_Stop);
    }
    private void OnClicked_Start()
    {
        if (!m_IsFire)
        {
            m_IsFire = true;
            StartCoroutine(EnumFire());
        }
    }
    IEnumerator EnumFire()
    {
        while (m_IsFire)
        {
            m_Turret.Fire();
            yield return new WaitForSeconds(1);
        }
    }

    private void OnClicked_Stop()
    {
        m_IsFire = false;
    }
}
