using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageCheck : MonoBehaviour {

    public Image randomImage;
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
    public Sprite s10;
    public Sprite s11;
    public Sprite s12;
    public Sprite s13;
    public Sprite s14;
    public Sprite s15;
    public Sprite s16;
    public Sprite s17;
    public Sprite s18;
    public Sprite s19;
    public Sprite s20;
    public Sprite s21;
    public Sprite s22;
    public Sprite s23;
    public Sprite s24;
    public Sprite s25;
    public Sprite s26;
    public Sprite s27;
    public Sprite s28;
    public Sprite s29;
    public Sprite[] images;

    public Text answer;
    public Text error;
    string randomWord;
    public static bool isAcceptable;
    public static int answerLength;
    private List<int> indexes = new List<int>();
    private int rnd;
    private int rnd2;

    public void SelectImage()
    {
        rnd = Random.Range(0, images.Length);

        if (indexes.Count == images.Length)
        {

            indexes.Clear();

            while (rnd == rnd2)
                rnd = Random.Range(0, images.Length);

        }

        else if (indexes.Count == images.Length - 1)
        {
            while (indexes.Contains(rnd))
            {
                rnd = Random.Range(0, images.Length);
            }
            rnd2 = rnd;
        }
        else
        {

            while (indexes.Contains(rnd))
            {
                rnd = Random.Range(0, images.Length);
            }

        }

        indexes.Add(rnd);
        randomImage.sprite = images[rnd];

    }

    // Use this for initialization
    void Start()
    {
        images = new Sprite[30];
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
        images[10] = s10;
        images[11] = s11;
        images[12] = s12;
        images[13] = s13;
        images[14] = s14;
        images[15] = s15;
        images[16] = s16;
        images[17] = s17;
        images[18] = s18;
        images[19] = s19;
        images[20] = s20;
        images[21] = s21;
        images[22] = s22;
        images[23] = s23;
        images[24] = s24;
        images[25] = s25;
        images[26] = s26;
        images[27] = s27;
        images[28] = s28;
        images[29] = s29;

        isAcceptable = false;

        int num = Random.Range(0, images.Length);
        indexes.Add(rnd);
        randomImage.sprite = images[num];

    }

    public void OnClickI()
    {
        isAcceptable = false;
        if (randomImage.sprite.name.ToString().ToUpper().Equals(answer.text.ToString().ToUpper()))
        {
            isAcceptable = true;
            answerLength = answer.text.Length;
            error.GetComponent<Text>();
            error.text = "";
            Timer.timeLeft += 3 * answerLength;

            SelectImage();
        }

        else
        {
            isAcceptable = false;
            error.GetComponent<Text>();
            error.text = "Wrong logo name. Please try again!";
        }
        answer.text = "";
    }

}