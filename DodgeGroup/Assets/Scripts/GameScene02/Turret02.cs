using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret02 : MonoBehaviour
{
    [SerializeField] Transform m_Head = null;
    [SerializeField] Transform m_BulletPos = null;
    [SerializeField] Transform m_BulletParent = null;
    [SerializeField] GameObject m_BulletPrefab = null;
    [SerializeField] Transform m_Target = null;
    [SerializeField] AudioSource m_audFire = null;
    private void Update()
    {
        m_Head.LookAt(m_Target);   
    }
    public void Fire()
    {
        m_audFire.Play();
        CreateBullet();
    }
    public void CreateBullet()
    {
        GameObject go = Instantiate(m_BulletPrefab,m_BulletParent);
        go.transform.position = m_BulletPos.transform.position;
        Bullet kBullet = go.GetComponent<Bullet>();
        kBullet.Initailize(m_Target);
    }
}
