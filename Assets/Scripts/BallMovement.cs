using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5.0f;
    Vector2 direction;

    SpriteRenderer spriteRenderer;
    BoxCollider2D collider;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
        RandomDirection();
    }

    void Update()
    {
        Vector3 change = direction * speed * Time.deltaTime;
        transform.position += change;
    }


    public bool IsColliding(float xMin, float xMax, float yMin, float yMax)
    {
        float halfW = collider.size.x * transform.localScale.x * 1 / 2;
        float halfH = collider.size.y * transform.localScale.y * 1 / 2;

        float ballXMin = transform.position.x - halfW;
        float ballXMax = transform.position.x + halfW;
        float ballYMin = transform.position.y - halfH;
        float ballYMax = transform.position.y + halfH;


        // print(ballXMin + "  " + ballXMax + "  " + ballYMin + "  " + ballYMax);
        // print(xMin + "  " + xMax + "  " + yMin + "  " + yMax);
        // print((ballXMax >= xMin) + " " + (ballXMin <= xMax) + " " + (ballYMax >= yMin) + " " + (ballYMin <= yMax));
        bool isColliding = !(ballXMax < xMin || ballXMin > xMax ||
                            ballYMax < yMin || ballYMin > yMax);

        return isColliding;
    }

    public void ChangeDirectionX()
    {
        print("Change X Direction");
        direction = new Vector2(-direction.x, direction.y);
    }
    public void ChangeDirectionY()
    {
        print("Change Y Direction");
        direction = new Vector2(direction.x, -direction.y);
    }

    public void RandomDirection()
    {
        transform.position = new Vector2(0, 0);
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }
}
