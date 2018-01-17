using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

    private string scene;
    private bool stop;
    private int i = 0;

    void Start()
    {
        scene = SceneManager.GetActiveScene().name;

        if (scene.Equals("Menu"))
        {
            i += 1;
            StartMenuMute.source2.Play();
            StartMenuMute.source2.mute = false;
            stop = true;
        }
        else if (scene.Equals("Start"))
        {
            
        }
    }

    void Awake() {

        GameObject obj = GameObject.FindGameObjectWithTag("music");

        DontDestroyOnLoad(this.gameObject);

    }

    public static void Destroy()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("music");
        Destroy(obj);
    }

    void Update()
    {

        scene = SceneManager.GetActiveScene().name;

        if (!scene.Equals("Menu") && !scene.Equals("Start"))
        {
            StartMenuMute.source2.mute = true;
        }

        else
        {


        }

    }

}
