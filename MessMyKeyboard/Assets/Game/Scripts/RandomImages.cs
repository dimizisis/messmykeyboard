using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomImages : MonoBehaviour {

    public Image randomImage;
    public static Image randomImageStat;
    public Sprite s0;
    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public Sprite s5;
    public Sprite s6;
    public Sprite s7;
    public Sprite s8;
    public Sprite s9;
    public Sprite[] images;


    public static bool isAcceptable = true;
    public static int answerLength;
    public Text answer;
    public Text error;


    void Start()
    {
        images = new Sprite[10];
        images[0] = s0;
        images[1] = s1;
        images[2] = s2;
        images[3] = s3;
        images[4] = s4;
        images[5] = s5;
        images[6] = s6;
        images[7] = s7;
        images[8] = s8;
        images[9] = s9;

        int num = UnityEngine.Random.Range(0, images.Length);
        randomImage.sprite = images[num];
        randomImageStat = randomImage;
    }

    public void changeImage() { 
    
        if (randomImageStat.sprite.name.ToString().Equals(answer.text.ToString())) { 
            int num = UnityEngine.Random.Range(0, images.Length);
            randomImage.sprite = images[num];
            randomImageStat = randomImage;
        }
    }

    public void OnClickI()
    {
        isAcceptable = false;

        answerLength = RandomImages.randomImageStat.sprite.name.Length;
        error.GetComponent<Text>();
        error.text = "";
        if (randomImageStat.sprite.name.ToString().Equals(answer.text.ToString()))
        {

            isAcceptable = true;
            Timer.timeLeft += 3 * answerLength;

        }

        else
        {
            isAcceptable = false;
            error.text = "Wrong logo name. Please try again!";
        }
        answer.text = "";

    }
}