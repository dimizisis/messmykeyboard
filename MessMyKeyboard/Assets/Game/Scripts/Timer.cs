using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public static float timeLeft = 100;
    public Text time;
    public Text gameOver;
    public Text score;
    public AudioClip lost;
    public AudioSource source;
    public float delay=2;

    // Use this for initialization
    void Start()
    {
        if (StartMenuMute.isMuted == false)
        {
            source = GetComponent<AudioSource>();
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
            time.text = ((int)timeLeft).ToString();
            timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            time.text = "0";
            gameOver.text = "Game over! Your score: " + score.text;
            source.Pause();
            this.gameObject.AddComponent<AudioSource>();
            this.GetComponent<AudioSource>().clip = lost;
            this.GetComponent<AudioSource>().Play(); 
            if (StartMenuMute.isMuted == true)
            {
                StartCoroutine(LoadLevelAfterDelay(delay));
                StartMenuMute.isMuted = true;
            }
            else
            {
                StartCoroutine(LoadLevelAfterDelay(delay));
                StartMenuMute.isMuted = false;
            }
            
        }
        
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Start");
    }
}