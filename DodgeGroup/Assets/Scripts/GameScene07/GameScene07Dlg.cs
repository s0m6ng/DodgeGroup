using UnityEngine;
using UnityEngine.UI;

public class GameScene07Dlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnStop = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] Text m_txtTimer = null;
    float m_Timer = 0f;
    bool m_IsTimer = false;
    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_btnStop.onClick.AddListener(OnClicked_Stop);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
    }
    private void Update()
    {
        int num = Mathf.FloorToInt(m_Timer);
        float min = num / 60;
        float sec = num % 60;
        float millisec = Mathf.FloorToInt(m_Timer * 100) - num * 100;
        m_txtTimer.text = $"{min:00}:{sec:00}:{millisec:00}";
        if (m_IsTimer)
        {
            m_Timer += Time.deltaTime;
        }
    }
    private void OnClicked_Start()
    {
        m_IsTimer = true;
    }

    private void OnClicked_Stop()
    {
        m_IsTimer = false;
    }

    private void OnClicked_Clear()
    {
        m_IsTimer = false;
        m_Timer = 0;
    }
}
