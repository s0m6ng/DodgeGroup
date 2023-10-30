using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameScene02Dlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnStop = null;
    [SerializeField] Turret02 m_Turret = null;
    bool m_IsFire = false;
    float m_FireTimer = 0;
    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_btnStop.onClick.AddListener(OnClicked_Stop);
    }
    private void Update()
    {
        if (m_IsFire)
        {
            m_FireTimer += Time.deltaTime;
            if (m_FireTimer >= 1)
            {
                m_FireTimer = 0;
                m_Turret.Fire();
            }
        }
    }
    private void OnClicked_Start()
    {
        if (!m_IsFire)
        {
            m_FireTimer = 0;
            m_IsFire = true;
            //StartCoroutine(EnumFire());
        }
    }
    IEnumerator EnumFire()
    {
        while (m_IsFire)
        {
            yield return new WaitForSeconds(1);
            m_Turret.Fire();
        }
    }

    private void OnClicked_Stop()
    {
        m_IsFire = false;
    }
}
