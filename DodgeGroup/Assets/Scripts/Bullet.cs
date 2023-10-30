using UnityEngine;

public class Bullet : MonoBehaviour
{
    float m_Speed = 4f;
    public void Initailize(Transform target)
    {
        transform.LookAt(target);
        Destroy(gameObject, 10);
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
