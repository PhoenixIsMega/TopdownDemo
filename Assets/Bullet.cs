using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject explode;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject explosionInstance = Instantiate(explode, transform.position, Quaternion.identity);
        Destroy(explosionInstance, 1.0f);
        Destroy(gameObject);
    }
}
