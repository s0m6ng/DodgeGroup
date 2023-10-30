using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MessageBoxDlg : MonoBehaviour
{
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnCancel = null;
    private void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnCancel.onClick.AddListener(OnClicked_Cancel);
    }

    private void OnClicked_Ok()
    {
        SceneManager.LoadScene("GameScene08");
        Destroy(transform.parent.gameObject);
    }

    private void OnClicked_Cancel()
    {
        Destroy(gameObject);
    }
}
