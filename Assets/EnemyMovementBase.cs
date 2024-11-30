using UnityEngine;

public class EnemyMovementBase : MonoBehaviour
{
    [SerializeField] GameObject playerTarget;
    [SerializeField] float moveSpeed = 5;

    private Rigidbody2D rb;

    private void Awake()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveDir = playerTarget.transform.position - transform.position;
        rb.linearVelocity = moveDir * moveSpeed;
    }
}
