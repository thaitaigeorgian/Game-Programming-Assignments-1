using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    public ParticleSystem particleSystem;
    Rigidbody2D rb;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); ;
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = false;
        Vector2 scale = transform.localScale;
        Quaternion particleRotation = particleSystem.transform.localRotation;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            particleRotation.y = 0;
            particleSystem.Play();
            isRunning = true;
            scale.x = 1;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            particleSystem.Play();
            particleRotation.y = 180;
            isRunning = true;
            scale.x = -1;
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        particleSystem.transform.localRotation = particleRotation;

        // anim.Play();
        anim.SetBool("isRunning", isRunning);


        transform.localScale = scale;

        if (Input.GetKey(KeyCode.Space))
        {
            // transform.Translate(Vector3.up * speed * Time.deltaTime);
            rb.AddForce(new Vector2(0, 10f));
        }
    }
}
