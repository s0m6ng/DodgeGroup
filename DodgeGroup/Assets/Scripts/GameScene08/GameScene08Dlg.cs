using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScene08Dlg : MonoBehaviour
{
    [SerializeField] Button m_btnScene01 = null;
    [SerializeField] Button m_btnScene02 = null;
    [SerializeField] Button m_btnScene03 = null;
    [SerializeField] Button m_btnScene04 = null;
    void Start()
    {
        m_btnScene01.onClick.AddListener(() => OnClicked_Scene(1));
        m_btnScene02.onClick.AddListener(() => OnClicked_Scene(2));
        m_btnScene03.onClick.AddListener(() => OnClicked_Scene(3));
        m_btnScene04.onClick.AddListener(() => OnClicked_Scene(4));
    }
    void OnClicked_Scene(int id)
    {
        switch (id)
        {
            case 1:
                SceneManager.LoadScene("GameScene01");
                break;
            case 2:
                SceneManager.LoadScene("GameScene02");
                break;
            case 3:
                SceneManager.LoadScene("GameScene03");
                break;
            case 4:
                SceneManager.LoadScene("GameScene04");
                break;
        }
    }
}
