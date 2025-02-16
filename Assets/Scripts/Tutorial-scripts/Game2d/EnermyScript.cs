using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyScript : MonoBehaviour
{
    public float start, end;
    private bool isRight = false;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float currentPosX = transform.position.x;


        if (currentPosX < start || currentPosX > end)
        {
            isRight = !isRight;
        }

        Vector3 direction = isRight ? Vector3.left : Vector3.right;

        transform.localScale = new Vector3(isRight ? 1 : -1, 1, 1);

        transform.Translate(direction * 5f * Time.deltaTime);

    }
}
