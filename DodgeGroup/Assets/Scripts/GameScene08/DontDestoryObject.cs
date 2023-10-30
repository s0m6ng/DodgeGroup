using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestoryObject : MonoBehaviour
{
    [SerializeField] GameObject m_MessageboxPrefab = null;
    GameObject m_Messagebox = null;
    [SerializeField] Scene m_CurScene;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Initialize()
    {
        m_Messagebox = null;
    }
    private void Update()
    {
        if (m_CurScene != SceneManager.GetActiveScene())
            m_CurScene = SceneManager.GetActiveScene();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name != "GameScene08" && m_Messagebox == null)
            {
                m_Messagebox = Instantiate(m_MessageboxPrefab, transform);
            }
        }
    }
}
