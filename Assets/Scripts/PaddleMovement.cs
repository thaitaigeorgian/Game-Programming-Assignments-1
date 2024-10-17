using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public float speed = 5.0f;

    public BallMovement ball; // Tham chiếu tới bóng
    BoxCollider2D collider;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        // Điều khiển paddle di chuyển lên xuống
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(upKey))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(downKey))
        {
            direction = Vector2.down;
        }

        Vector3 change = direction * speed * Time.deltaTime;

        if (transform.position.y + change.y < 4.0f && transform.position.y + change.y > -4.0f)
        {
            transform.position += change;
        }

        BallDetection();
    }

    void BallDetection()
    {

        float halfW = collider.size.x * transform.localScale.x * 1 / 2;
        float halfH = collider.size.y * transform.localScale.y * 1 / 2;

        float paddleMinX = transform.position.x - halfW;
        float paddleMaxX = transform.position.x + halfW;
        float paddleMinY = transform.position.y - halfH;
        float paddleMaxY = transform.position.y + halfH;

        bool isColliding = ball.IsColliding(paddleMinX, paddleMaxX, paddleMinY, paddleMaxY);

        if (isColliding) ball.ChangeDirectionX();

    }
}
