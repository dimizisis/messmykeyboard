using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerSoundsWord : MonoBehaviour {

    public AudioClip error;
    public AudioClip success;

    // Use this for initialization
    void Start()
    {

    }

    public void PlaySound()
    {

        if (WordCheck.isAcceptable == true)
        {
            this.gameObject.AddComponent<AudioSource>();
            this.GetComponent<AudioSource>().clip = success;
            this.GetComponent<AudioSource>().Play();
        }
        else
        {
            this.gameObject.AddComponent<AudioSource>();
            this.GetComponent<AudioSource>().clip = error;
            this.GetComponent<AudioSource>().Play();

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}