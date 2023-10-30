using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret01 : MonoBehaviour
{
    [SerializeField] Transform m_Head = null;
    [SerializeField] Transform m_BulletPos = null;
    [SerializeField] GameObject m_PrefabBullet = null;
    [SerializeField] Transform m_Target = null;
    [SerializeField] Transform m_BulletParent = null;

    private void Start()
    {
    }

    private void Initialize()
    {
    }
    private void Update()
    {
        m_Head.LookAt(m_Target);
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    void CreateBullet()
    {
        GameObject go = Instantiate(m_PrefabBullet, m_BulletParent);
        go.transform.position = m_BulletPos.position;
        Bullet kbullet = go.GetComponent<Bullet>();
        kbullet.Initailize(m_Target);
    }
    void Fire()
    {
        CreateBullet();
    }
}
