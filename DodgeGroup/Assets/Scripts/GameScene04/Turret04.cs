using System.Collections;
using UnityEngine;

public class Turret04 : MonoBehaviour
{
    [SerializeField] GameObject m_BulletPrefab = null;
    [SerializeField] Transform m_Head = null;
    [SerializeField] Transform m_FirePos = null;
    [SerializeField] Transform m_BulletParent = null;
    [SerializeField] Transform m_Target = null;
    [SerializeField] AudioSource m_audFire = null;
    Coroutine m_cor = null;
    bool m_IsFire = false;
    void Update()
    {
        m_Head.transform.LookAt(m_Target);
    }
    public void StartFire()
    {
        if (!m_IsFire)
        {
            m_IsFire = true;
            m_cor = StartCoroutine(Fire(1));
        }
    }
    public void StopFire()
    {
        m_IsFire=false;
        if(m_cor!= null)
            StopCoroutine(m_cor);
    }
    IEnumerator Fire(float wait)
    {
        while (m_IsFire)
        {
            CreateBullet();
            yield return new WaitForSeconds(wait);
        }
    }
    public void CreateBullet()
    {
        m_audFire.Play();
        GameObject go = Instantiate(m_BulletPrefab, m_BulletParent);
        go.transform.position = m_FirePos.position;
        Bullet kBullet = go.GetComponent<Bullet>();
        kBullet.Initailize(m_Target);
    }
}
