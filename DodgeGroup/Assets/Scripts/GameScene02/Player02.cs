using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02 : MonoBehaviour
{
    public float m_Speed = 5.0f;
    void Update()
    {
        float hz = Input.GetAxis("Horizontal");
        float vt= Input.GetAxis("Vertical");

        transform.position += new Vector3(hz, 0, vt) * m_Speed * Time.deltaTime;
    }
}
