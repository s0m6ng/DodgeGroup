using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Player : MonoBehaviour
{
    public float m_Speed = 3.0f;
    Rigidbody rb = null;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }
    void Move()
    {
        float vx = Input.GetAxisRaw("Horizontal");
        float vz = Input.GetAxisRaw("Vertical");
        Vector3 vel = new Vector3(vx,0, vz) * m_Speed * Time.deltaTime;
        rb.velocity = vel;
    }
}
