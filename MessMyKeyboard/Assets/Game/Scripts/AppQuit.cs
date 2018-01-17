using UnityEngine;

public class AppQuit : MonoBehaviour {

    public void ExitApp()
    {
            Application.Quit();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}