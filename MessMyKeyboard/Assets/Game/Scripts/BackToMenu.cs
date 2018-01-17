using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Start");
        }
    }

    public void Back()
    {
        SceneManager.LoadScene("Start");
    }
}
