using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public string level;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("SentenceGame2");
            Timer.timeLeft = 100;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(level);
        Timer.timeLeft = 100;
    }
}
