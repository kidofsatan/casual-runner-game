using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 10f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * speed;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Обработка столкновения
        Destroy(gameObject); // Уничтожаем пулю при столкновении
    }
}
