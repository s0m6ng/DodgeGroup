using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform m_Target = null;
    float m_Speed = 3f;
    private void Start()
    {
        transform.LookAt(m_Target);
    }
    private void Update()
    {
        Move();
    }
    void Move()
    {
        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }
}
