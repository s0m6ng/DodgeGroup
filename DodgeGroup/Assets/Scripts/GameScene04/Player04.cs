using UnityEngine;

public class Player04 : MonoBehaviour
{
    [SerializeField] AudioSource m_audNuke = null;
    [SerializeField] FXParticle m_ptcNuke = null;
    public float m_Speed = 10;
    Rigidbody m_rb;
    private void Awake()
    {
        m_rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }
    void Move()
    {
        float dx = Input.GetAxisRaw("Horizontal");
        float dz = Input.GetAxisRaw("Vertical");

        m_rb.velocity = new Vector3(dx, 0, dz) * m_Speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            m_audNuke.Play();
            m_ptcNuke.Play();
            Destroy(other.gameObject);
        }
    }
}
