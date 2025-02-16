using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    public Vector2 acc = Physics.gravity;
    Vector2 direction = Vector2.up;
    Vector2 vel;
    void Start()
    {
        vel = direction * 10.0f;
    }

    void Update()
    {
        // velocity = acceleration * time
        // position = velocity * time
        float dt = Time.deltaTime;
        vel += acc * dt;
        Vector3 change = vel * dt;
        transform.position += change;

        // Improvement: store initial position and initial velocity
        // (So you're not hard-coding position <= -5 and vel = [0, 10])
        if (transform.position.y <= -5.0f)
        {
            transform.position = new Vector3(transform.position.x, -5.0f);
            vel = new Vector2(vel.x, -vel.y);
        }

        if (transform.position.y >= 5.0f)
        {
            transform.position = new Vector3(transform.position.x, 5.0f);
            vel = new Vector2(vel.x, -vel.y);
        }

        if (transform.position.x <= -10.0f)
        {
            transform.position = new Vector3(-10.0f, transform.position.y);
            vel = new Vector2(-vel.x, vel.y);
        }

        if (transform.position.x >= 10.0f)
        {
            transform.position = new Vector3(10.0f, transform.position.y);
            vel = new Vector2(-vel.x, vel.y);
        }

    }

    public void SetVel(int number)
    {
        print(number);
        switch (number)
        {
            case 1:
                direction = Vector2.up;
                break;
            case 2:
                direction = Vector2.down;
                break;
            case 3:
                direction = Vector2.left;
                break;
            default:
                direction = Vector2.right;
                break;
        }

        vel = direction * 10.0f;
    }
}
