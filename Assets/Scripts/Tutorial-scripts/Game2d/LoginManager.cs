using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoginManager : MonoBehaviour
{
    public TMP_InputField usernameField, passwordField;
    public TMP_Text loginResultMeshPro;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckLogin()
    {

        if (usernameField.text.Equals("username") && passwordField.text.Equals("password"))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            loginResultMeshPro.text = "Username or password is not valid";
        }
    }
}
