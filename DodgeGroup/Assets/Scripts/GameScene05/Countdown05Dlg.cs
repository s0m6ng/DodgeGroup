using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown05Dlg : MonoBehaviour
{
    [SerializeField] Text m_txtCountdown = null;
    bool m_IsScale = false;
    public void Initialize()
    {
        StartCoroutine(EnumCountdown());
        m_txtCountdown.gameObject.SetActive(true);
    }
    IEnumerator EnumCountdown()
    {
        for (int i = 3; i >= 0; i--)
        {
            m_txtCountdown.transform.localScale = Vector3.one;
            if (i > 0)
            {
                m_txtCountdown.text = i.ToString();
                StartCoroutine(EnumTextScale());
                yield return new WaitForSeconds(0.5f);
                m_IsScale = false;
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                m_txtCountdown.text = "Start";
                yield return new WaitForSeconds(1f);
            }
        }
        m_txtCountdown.gameObject.SetActive(false);
    }
    IEnumerator EnumTextScale()
    {
        m_IsScale = true;
        float scale = 0;
        while (m_IsScale)
        {
            scale+= 0.001f;
            m_txtCountdown.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, scale);
            yield return new WaitForFixedUpdate();
        }
    }
}
