using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public string playerName;
    public BallMovement ball;
    BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BallDetection();
    }

    void BallDetection()
    {

        float halfW = collider.size.x * transform.localScale.x * 1 / 2;
        float halfH = collider.size.y * transform.localScale.y * 1 / 2;

        float wallMinX = transform.position.x - halfW;
        float wallMaxX = transform.position.x + halfW;
        float wallMinY = transform.position.y - halfH;
        float wallMaxY = transform.position.y + halfH;

        bool isColliding = ball.IsColliding(wallMinX, wallMaxX, wallMinY, wallMaxY);

        if (isColliding)
        {
            print("+++++++ ONE POINT FOR " + playerName);
            ball.RandomDirection();
        };

    }
}
