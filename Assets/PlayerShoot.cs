using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform gunTransform;
    [SerializeField] private float gunForce;
    private Vector2 mousePos;
    private Transform trans;


    private void Awake()
    {
        trans = GetComponent<Transform>();
    }

    private void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, gunTransform.position, gunTransform.rotation);
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.linearVelocity = (gunTransform.up * gunForce);
        }
    }
    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - (Vector2) transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90.0f;
        trans.eulerAngles = new Vector3(0, 0, angle);
    }
}
