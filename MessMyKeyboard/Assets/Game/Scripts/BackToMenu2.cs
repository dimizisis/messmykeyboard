using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            DontDestroy.Destroy();
            SceneManager.LoadScene("Menu");
        }
    }

    public void Back()
    {
        DontDestroy.Destroy();
        SceneManager.LoadScene("Menu");
    }
}