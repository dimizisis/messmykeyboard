using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenu : MonoBehaviour {

	public void Exit()
    {
        if (StartMenuMute.isMuted == false)
        {
            StartMenuMute.source2.mute = false;
        }

        SceneManager.LoadScene("Start");
    }

    void Update()
    {
       

        if (Input.GetKey(KeyCode.Escape))
        {
            if (StartMenuMute.isMuted == false)
            {
                StartMenuMute.source2.Play();
            }
            SceneManager.LoadScene("Start");
        }
    }
}
