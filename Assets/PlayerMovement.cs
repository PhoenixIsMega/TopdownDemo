using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Vector2 velocityVector;
    private Rigidbody2D rb;
    //add animator here
    void Start() { }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetVelocity(Vector2 velocityVector) {
        this.velocityVector = velocityVector;
    }

    private void Update()
    {
        velocityVector.x = Input.GetAxisRaw("Horizontal");
        velocityVector.y = Input.GetAxisRaw("Vertical");
        velocityVector.Normalize();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = velocityVector * moveSpeed;
        //play move animation
    }
}
