using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player03 : MonoBehaviour
{
    public float m_Speed = 5.0f;
    [SerializeField] FXParticle m_ptcNuke;
    [SerializeField] AudioSource m_audNuke;
    void Update()
    {
        float hz = Input.GetAxis("Horizontal");
        float vt= Input.GetAxis("Vertical");

        transform.position += new Vector3(hz, 0, vt) * m_Speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            m_ptcNuke.Play();
            m_audNuke.Play();
        }
    }
}
