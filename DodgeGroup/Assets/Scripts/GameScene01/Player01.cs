using UnityEngine;

public class Player01 : MonoBehaviour
{
    const float DEFAULT_SPEED = 10;
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
        float vx = Input.GetAxisRaw("Horizontal") * m_Speed * Time.deltaTime * DEFAULT_SPEED; ;
        float vz = Input.GetAxisRaw("Vertical") * m_Speed * Time.deltaTime * DEFAULT_SPEED; ;

        transform.Translate(vx, 0, vz, Space.World);
    }
}
