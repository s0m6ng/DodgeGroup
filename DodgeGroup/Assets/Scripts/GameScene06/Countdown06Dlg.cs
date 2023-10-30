using UnityEngine;
using UnityEngine.UI;

public class Countdown06Dlg : MonoBehaviour
{
    [SerializeField] Text m_txtCountdown = null;
    float m_Timer = 0;
    int m_Count = 0;
    public void Initialize()
    {
        m_txtCountdown.gameObject.SetActive(true);
        m_Count = 3;
        m_txtCountdown.text = "3";
    }
    void Update()
    {
        if (m_Count >= 0)
        {
            m_txtCountdown.gameObject.SetActive(true);
            m_Timer += Time.deltaTime;
            if (m_Timer >= 1)
            {
                m_Timer = 0;
                m_txtCountdown.transform.localScale = Vector3.one;
                m_Count--;
            }
            if (m_Count > 0)
            {
                m_txtCountdown.text = m_Count.ToString();
                m_txtCountdown.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * 0.7f, m_Timer*2);
            }
            else
            {
                m_txtCountdown.text = "Start";
            }
        }
        else
        {
            m_txtCountdown.gameObject.SetActive(false);
        }
    }
}
