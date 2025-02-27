using UnityEngine;

public class RobotMove : MonoBehaviour
{
    float speedX;
    float speedY;
    public float speed;
    Rigidbody2D rb;
    private bool isFacingRight = false;
    public float jump;

    public Transform inGround;
    public LayerMask groundLayer;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(inGround.position, new Vector2(2.5f, 1.0f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        speedX = Input.GetAxisRaw("Horizontal") * speed;
        //speedY = Input.GetAxisRaw("Vertical") * speed;

        if (Input.GetButton("Jump"))
        {
            rb.AddForce(new Vector2(rb.linearVelocity.x, jump));
        }
        rb.linearVelocity = new Vector2(speedX, speedY);

        flip();
    }

    private void flip()
    {
        if ((isFacingRight && speedX < 0f) || (!isFacingRight && speedX > 0f))
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
