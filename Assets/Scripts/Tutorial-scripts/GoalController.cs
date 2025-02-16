using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour
{

    public ParticleSystem particleSystem;


    void OnTriggerEnter2D(Collider2D collider)
    {
        print("OnTriggerEnter2D");

        if (collider.CompareTag("Player"))
        {
            particleSystem.Play();
            print("Player enter Goal");
            Invoke("RestartScene", 2f);


        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(1);
    }
}
